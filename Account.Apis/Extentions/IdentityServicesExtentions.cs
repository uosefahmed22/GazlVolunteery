using Account.Core.Models.Account;
using Account.Core.Services.Identity;
using Account.Reposatory.Data.Content;
using Account.Reposatory.Reposatories.Identity;
using Account.services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Account.Apis.Extentions
{
    public static class IdentityServicesExtentions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<AppUser, IdentityRole>(Options =>
            {
            })
            .AddEntityFrameworkStores<AppDBContext>()
            .AddDefaultTokenProviders().AddRoles<IdentityRole>();

            services.AddAuthentication(Options =>
            {
                Options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                Options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(Options =>
            {
                Options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    ValidateAudience = true,
                    ValidAudience = configuration["JWT:ValidAudience"],
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:key"]))
                };
            });

            services.AddDbContext<AppDBContext>(Options =>
            {
                Options.UseSqlServer(configuration.GetConnectionString("JadAuthIdentity"));
            });

            // Register custom token service
            services.AddScoped<IAccountService,AccountService>();
            services.AddScoped<IOtpService, OtpService>();
            services.AddScoped<ITokenService,TokenService>();

            return services;
        }

    }
}
