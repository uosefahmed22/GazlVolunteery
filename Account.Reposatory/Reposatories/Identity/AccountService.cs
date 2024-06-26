﻿using Account.Apis.Errors;
using Account.Core.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MailKit.Security;
using Account.Core.Dtos.Account;
using Account.Core.Errors;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Memory;
using Account.Core.Enums;
using Account.Core.Services.Identity;
using System.Data;

namespace Account.Reposatory.Reposatories.Identity
{
    public class AccountService : IAccountService
    {
        #region MyRegion
        private readonly UserManager<AppUser> _userManager;
        private readonly MailSettings _mailSettings;
        private readonly ITokenService _TokenService;
        private readonly IOtpService _otpService;
        private readonly IMemoryCache _cache;

        public AccountService(UserManager<AppUser> userManager,
            IOptionsMonitor<MailSettings> options,
            ITokenService tokenService,
            IOtpService otpService,
            IMemoryCache cache
            )
        {
            _userManager = userManager;
            _mailSettings = options.CurrentValue;
            _TokenService = tokenService;
            _otpService = otpService;
            _cache = cache;
        }
        #endregion

        public async Task<ApiResponse> RegisterAsync(Register dto, Func<string, string, string> generateCallBackUrl)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);
            if (user is not null)
            {
                return new ApiResponse(400, "User with this email already exists.");
            }

            if (dto.Charity.HasValue && dto.GovernmentAgency.HasValue)
            {
                return new ApiResponse(400, "Please choose either a charity or a government agency, not both.");
            }

            user = new AppUser
            {
                DisplayName = dto.DisplayName,
                Email = dto.Email,
                UserName = dto.Email.Split('@')[0],
                UserRole = (int)dto.UserRole,
                EmailConfirmed = false,
                Charity = dto.Charity.HasValue ? (int)dto.Charity : (int?)null,
                GovernmentAgency = dto.GovernmentAgency.HasValue ? (int)dto.GovernmentAgency : (int?)null
            };


            var result = await _userManager.CreateAsync(user, dto.Password);

            if (!result.Succeeded)
            {
                return new ApiResponse(400, "Something went wrong with the data you entered");
            }

            var roleName = GetUserRoleName(dto.UserRole);
            await _userManager.AddToRoleAsync(user, roleName);

            var emailConfirmation = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var callBackUrl = generateCallBackUrl(emailConfirmation, user.Id);
            var emailBody = $"<h1>Dear {user.UserName}! Welcome To Jazal.</h1><p>Please <a href='{callBackUrl}'>Click Here</a> To Confirm Your Email.</p>";

            await SendEmailAsync(user.Email, "Email Confirmation", emailBody);

            return new ApiResponse(200, "Email verification has been sent to your email successfully. Please verify it!");
        }
        public static string GetUserRoleName(UserRoleEnum role)
        {
            switch (role)
            {
                case UserRoleEnum.Visitor:
                    return "Visitor";
                case UserRoleEnum.GovernmentAgency:
                    return "GovernmentAgency";
                case UserRoleEnum.CivilOrganization:
                    return "CivilOrganization";
                case UserRoleEnum.PrivateSector:
                    return "PrivateSector";
                default:
                    return "Unknown";
            }
        }
        public async Task<UserDto> LoginAsync(LoginDto dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);

            if (user is null)
            {
                return new UserDto
                {
                    StatusCode = 400,
                    Message = "User with this email does not exist."
                };
            }

            var isValidPassword = await _userManager.CheckPasswordAsync(user, dto.Password);

            if (!isValidPassword)
            {
                return new UserDto
                {
                    StatusCode = 400,
                    Message = "Invalid password."
                };
            }

            var roles = await _userManager.GetRolesAsync(user);
            var role = roles.FirstOrDefault();

            var charity = user.Charity.HasValue ? (CharitiesEnum)user.Charity.Value : CharitiesEnum.Null;
            var govAgency = user.GovernmentAgency.HasValue ? (GoverrateAgancyEnum)user.GovernmentAgency.Value : GoverrateAgancyEnum.GoverrateAgancy1;

            return new UserDto
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
                Role = GetRoleEnum(role),
                Charity = charity,
                GovernmentAgency = govAgency,
                Token = await _TokenService.CreateTokenAsync(user)
            };
        }
        private UserRoleEnum GetRoleEnum(string role)
        {
            return role switch
            {
                "Visitor" => UserRoleEnum.Visitor,
                "GovernmentAgency" => UserRoleEnum.GovernmentAgency,
                "CivilOrganization" => UserRoleEnum.CivilOrganization,
                "PrivateSector" => UserRoleEnum.PrivateSector
            };
        }
        public async Task<ApiResponse> ForgetPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email address is required.", nameof(email));
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return new ApiResponse(400, "User not found.");
            }

            var otp = _otpService.GenerateOtp(email);

            try
            {
                await SendEmailAsync(email,
                    "Verification Code",
                    $"Dear {user.UserName},<br/> Use this code to reset your password: <strong>{otp}</strong>. Keep it safe and do not share it with anyone.");

                return new ApiResponse(200, "Password reset email sent successfully.");
            }
            catch (Exception ex)
            {
                return new ApiResponse(500, "An unexpected error occurred while sending the password reset email. Please try again later.");
            }
        }
        public ApiResponse VerfiyOtp(VerifyOtp dto)
        {
            var isValidOtp = _otpService.IsValidOtp(dto.Email, dto.Otp);

            if (!isValidOtp)
            {
                return new ApiResponse(400, "Invalid OTP.");
            }
            return new ApiResponse(200, "Valid");
        }
        public async Task<ApiResponse> ResetPasswordAsync(ResetPassword dto)
        {
            var user = await _userManager.FindByEmailAsync(dto.Email);

            if (user == null)
            {
                return new ApiResponse(400, "User not found.");
            }

            if (!_cache.TryGetValue(dto.Email, out bool validOtp) || !validOtp)
            {
                return new ApiResponse(400, "You have not verified your email addres(OTP).");
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            var result = await _userManager.ResetPasswordAsync(user, token, dto.Password);

            if (result.Succeeded)
            {
                return new ApiResponse(200, "Password reset successfully.");
            }
            else
            {
                return new ApiResponse(500, "Failed to reset password.");
            }
        }
        public async Task<bool> ConfirmUserEmailAsync(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return false;
            }

            var confirmed = await _userManager.ConfirmEmailAsync(user, token);

            return confirmed.Succeeded;
        }
        public async Task SendEmailAsync(string To, string Subject, string Body, CancellationToken Cancellation = default)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(_mailSettings.DisplayedName, _mailSettings.Email));
            message.To.Add(new MailboxAddress("", To));
            message.Subject = Subject;

            message.Body = new TextPart("html")
            {
                Text = Body
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                await client.ConnectAsync(_mailSettings.SmtpServer, _mailSettings.Port,
                    SecureSocketOptions.StartTls, Cancellation);
                await client.AuthenticateAsync(_mailSettings.Email, _mailSettings.Password, Cancellation);
                await client.SendAsync(message, Cancellation);
                await client.DisconnectAsync(true, Cancellation);
            }
        }
       
    }
}
