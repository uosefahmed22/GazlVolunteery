using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Models.Content
{
    public class AssociationModel : BaseEntity
    {
        [Display(Name = "الاسم")]
        [Required(ErrorMessage = "اسم المستفيد مطلوب")]
        public string Name { get; set; }

        [Display(Name = "رقم التواصل")]
        public string Contact { get; set; }

        [Display(Name = "خط الطول")]
        [Range(-180, 180, ErrorMessage = "القيمة الصحيحة لخط الطول هي بين -180 و 180")]
        public decimal Longitude { get; set; }

        [Display(Name = "خط العرض")]
        [Range(-90, 90, ErrorMessage = "القيمة الصحيحة لخط العرض هي بين -90 و 90")]
        public decimal Latitude { get; set; }
    }

}
