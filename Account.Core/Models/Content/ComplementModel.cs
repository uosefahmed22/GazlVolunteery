using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Models.Content
{
    public class ComplementModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "اسم المرسل مطلوب")]
        [RegularExpression(@"^[\p{L}\s]+$", ErrorMessage = "الرجاء إدخال أحرف عربية أو إنجليزية فقط")]
        [Display(Name = "اسم المرسل")]
        public string SenderName { get; set; }

        [Required(ErrorMessage = "رقم الهوية مطلوب")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "رقم الهوية السعودية يجب أن يتكون من 10 أرقام.")]
        [Display(Name = "رقم الهوية")]
        public string NationalId { get; set; }

        [Required(ErrorMessage = "رقم الهاتف مطلوب")]
        [RegularExpression(@"^(05|5)([0-9]{8})$", ErrorMessage = "رقم التواصل غير صالح")]
        [Display(Name = "رقم الهاتف")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "تفاصيل الشكوى مطلوبة")]
        [Display(Name = "تفاصيل الشكوى")]
        public string ComplaintDetails { get; set; }
    }
}
