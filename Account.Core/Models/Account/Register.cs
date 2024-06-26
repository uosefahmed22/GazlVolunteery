﻿using Account.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Models.Account
{
    public class Register
    {
        public string DisplayName { get; set; }

        [Display(Name = "البريد الإلكتروني")]
        [EmailAddress(ErrorMessage = "عنوان البريد الإلكتروني غير صالح")]
        public string Email { get; set; }

        public string ContactNumbers { get; set; }

        [Display(Name = "رقم الهوية السعودية")]
        public string SaudiNationalID { get; set; }

        [Display(Name = "كلمة المرور")]
        public string Password { get; set; }

        [Display(Name = "تأكيد كلمة المرور")]
        [Compare("Password", ErrorMessage = "كلمات المرور غير متطابقة")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "الدور")]
        public UserRoleEnum UserRole { get; set; }
        [Display(Name = "الجمعية الخيرية")]
        public CharitiesEnum? Charity { get; set; }

        [Display(Name = "الجهة الحكومية")]
        public GoverrateAgancyEnum? GovernmentAgency { get; set; }
    }

}
