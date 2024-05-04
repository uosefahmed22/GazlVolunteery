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
        [Display(Name = "اسم المرسل")]
        public string SenderName { get; set; }

        [Required(ErrorMessage = "رقم الهوية مطلوب")]
        [Display(Name = "رقم الهوية")]
        public string NationalId { get; set; }

        [Required(ErrorMessage = "رقم الهاتف مطلوب")]
        [Display(Name = "رقم الهاتف")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "تفاصيل الشكوى مطلوبة")]
        [Display(Name = "تفاصيل الشكوى")]
        public string ComplaintDetails { get; set; }
    }
}
