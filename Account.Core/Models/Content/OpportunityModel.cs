using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Models.Content
{
    public class OpportunityModel : BaseEntity
    {
        [Display(Name = "النوع")]
        [Required(ErrorMessage = "نوع الفرصة مطلوب")]
        public string OpportunityType { get; set; }

        [Display(Name = "الجهة المنفذة")]
        [Required(ErrorMessage = "الجهة المنفذة مطلوبة")]
        public string ImplementingEntity { get; set; }

        [Display(Name = "العدد المتاح")]
        [Range(0, int.MaxValue, ErrorMessage = "العدد المتاح يجب أن يكون أكبر من صفر")]
        public int AvailableCount { get; set; }

        [Display(Name = "رقم الاتصال")]
        [RegularExpression(@"^(05|5)([0-9]{8})$", ErrorMessage = "رقم الاتصال غير صالح")]
        public string ContactNumber { get; set; }

        [Display(Name = "خط الطول")]
        [Range(-180, 180, ErrorMessage = "القيمة الصحيحة لخط الطول هي بين -180 و 180")]
        public decimal Longitude { get; set; }

        [Display(Name = "خط العرض")]
        [Range(-90, 90, ErrorMessage = "القيمة الصحيحة لخط العرض هي بين -90 و 90")]
        public decimal Latitude { get; set; }
    }
}
