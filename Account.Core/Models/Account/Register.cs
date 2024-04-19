using Account.Core.Enums;
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
        [RegularExpression(@"^[a-zA-Z\u0600-\u06FF\s]+$", ErrorMessage = "الأحرف العربية والإنجليزية فقط مسموح بها.")]
        public string DisplayName { get; set; }

        [Display(Name = "جمعية خيرية")]
        public CharitiesEnum? Charities { get; set; }

        [Display(Name = "وكالة المحافظة")]
        public GoverrateAgancyEnum? GoverrateAgancy { get; set; }

        [Display(Name = "البريد الإلكتروني")]
        [EmailAddress(ErrorMessage = "عنوان البريد الإلكتروني غير صالح")]
        public string Email { get; set; }

        [RegularExpression(@"^(\+?966|01[0-9])([0-9]{8})$", ErrorMessage = "رقم التواصل غير صالح")]
        public string ContactNumbers { get; set; }

        [Display(Name = "رقم الهوية السعودية")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "رقم الهوية السعودية يجب أن يتكون من 10 أرقام.")]
        public string SaudiNationalID { get; set; }

        [Display(Name = "كلمة المرور")]
        [MinLength(8, ErrorMessage = "الحد الأدنى للطول هو 8 أحرف")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "يجب أن تحتوي كلمة المرور على حرف كبير واحد على الأقل، وحرف صغير واحد على الأقل، ورقم واحد على الأقل، وحرف خاص واحد على الأقل.")]
        public string Password { get; set; }

        [Display(Name = "تأكيد كلمة المرور")]
        [MinLength(8, ErrorMessage = "الحد الأدنى للطول هو 8 أحرف")]
        [Compare("Password", ErrorMessage = "كلمات المرور غير متطابقة")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "هل أنت متطوع؟")]
        public bool IsVolunteer { get; set; }
    }

}
