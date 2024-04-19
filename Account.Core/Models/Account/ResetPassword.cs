using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Models.Account
{
    public class ResetPassword
    {
        [Display(Name = "البريد الإلكتروني")]
        [EmailAddress(ErrorMessage = "عنوان البريد الإلكتروني غير صالح")]
        public string Email { get; set; }

        [Display(Name = "كلمة المرور")]
        [MinLength(8, ErrorMessage = "الحد الأدنى للطول هو 8 أحرف")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "يجب أن تحتوي كلمة المرور على حرف كبير واحد على الأقل، وحرف صغير واحد على الأقل، ورقم واحد على الأقل، وحرف خاص واحد على الأقل.")]
        public string Password { get; set; }

        [Display(Name = "تأكيد كلمة المرور")]
        [MinLength(8, ErrorMessage = "الحد الأدنى للطول هو 8 أحرف")]
        [Compare("Password", ErrorMessage = "كلمات المرور غير متطابقة")]
        public string ConfirmPassword { get; set; }
    }
}
