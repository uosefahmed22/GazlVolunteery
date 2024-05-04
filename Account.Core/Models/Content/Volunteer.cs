using Account.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Models.Content
{
    using System.ComponentModel.DataAnnotations;
    public class Volunteer : BaseEntity
    {
        [Display(Name = "اسم المستفيد")]
        [Required(ErrorMessage = "اسم المستفيد مطلوب")]
        public string Name { get; set; }

        [Display(Name = "جهة التنفيذ")]
        [Required(ErrorMessage = "جهة التنفيذ مطلوبة")]
        public string ExecutingEntity { get; set; }

        [Display(Name = "نوع الطلب")]
        [Required(ErrorMessage = "نوع الطلب مطلوب")]
        public string RequestType { get; set; }

        [Display(Name = "رقم التواصل")]
        public string ContactNumbers { get; set; }

        [Display(Name = "رقم الهوية السعودية")]
        public string SaudiNationalID { get; set; }

        [Display(Name = "خط الطول")]
        [Range(-180, 180, ErrorMessage = "القيمة الصحيحة لخط الطول هي بين -180 و 180")]
        public decimal Longitude { get; set; }

        [Display(Name = "خط العرض")]
        [Range(-90, 90, ErrorMessage = "القيمة الصحيحة لخط العرض هي بين -90 و 90")]
        public decimal Latitude { get; set; }

        [Display(Name = "لون")]
        public string Color { get; set; } = "Red";
    }


}
