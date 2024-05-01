using Account.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Dtos.Content
{
    public class AssociationModelDto
    {
        [Display(Name = "الاسم")]
        [Required(ErrorMessage = "اسم المستفيد مطلوب")]
        [RegularExpression(@"^[\p{L}\s]+$", ErrorMessage = "الرجاء إدخال أحرف عربية أو إنجليزية فقط")]
        public string Name { get; set; }

        [Display(Name = "رقم التواصل")]
        [RegularExpression(@"^(05|5)([0-9]{8})$", ErrorMessage = "رقم التواصل غير صالح")]
        public string Contact { get; set; }

        [Display(Name = "خط الطول")]
        [Range(-180, 180, ErrorMessage = "القيمة الصحيحة لخط الطول هي بين -180 و 180")]
        public decimal Longitude { get; set; }

        [Display(Name = "خط العرض")]
        [Range(-90, 90, ErrorMessage = "القيمة الصحيحة لخط العرض هي بين -90 و 90")]
        public decimal Latitude { get; set; }
    }
}
