using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Models.Account
{
    using System.ComponentModel.DataAnnotations;

    public class VerifyOtp
    {
        [Display(Name = "البريد الإلكتروني")]
        [Required(ErrorMessage = "البريد الإلكتروني مطلوب")]
        [EmailAddress(ErrorMessage = "عنوان البريد الإلكتروني غير صالح")]
        public string Email { get; set; }

        [Display(Name = "رمز التحقق")]
        [Required(ErrorMessage = "رمز التحقق مطلوب")]
        [RegularExpression("^[0-9]{6}$", ErrorMessage = "يجب أن يحتوي رمز التحقق على 6 أرقام فقط")]
        [StringLength(6, ErrorMessage = "يجب أن يكون رمز التحقق مكونًا من 6 أرقام", MinimumLength = 6)]
        public string Otp { get; set; }
    }

}
