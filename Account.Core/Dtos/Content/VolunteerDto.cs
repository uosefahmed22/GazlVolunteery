using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Dtos.Content
{
    public class VolunteerDto
    {
        [Display(Name = "اسم المستفيد")]
        [Required(ErrorMessage = "يرجى إدخال اسم المستفيد")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "يجب أن يكون طول اسم المستفيد بين 2 و 100 حرف")]
        public string Name { get; set; }

        [Display(Name = "جهة التنفيذ")]
        [Required(ErrorMessage = "يرجى إدخال جهة التنفيذ")]
        public string ExecutingEntity { get; set; }

        [Display(Name = "نوع الطلب")]
        [Required(ErrorMessage = "يرجى إدخال نوع الطلب")]
        public string RequestType { get; set; }

        [Display(Name = "رقم التواصل")]
        [Required(ErrorMessage = "يرجى إدخال رقم التواصل")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "يجب أن يحتوي رقم التواصل على أرقام فقط")]
        public string ContactNumbers { get; set; }

        [Display(Name = "خط الطول")]
        [Required(ErrorMessage = "يرجى إدخال خط الطول")]
        public string Longitude { get; set; }

        [Display(Name = "خط العرض")]
        [Required(ErrorMessage = "يرجى إدخال خط العرض")]
        public string Latitude { get; set; }

        public string Color { get; } = "Red";
    }

}
