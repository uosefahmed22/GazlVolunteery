using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Enums
{
    public enum CharitiesEnum
    {
        [Display(Name = "جمعية البر الخيرية إيتاء")]
        charity1,

        [Display(Name = "جمعية الإسكان التنموي")]
        charity2,

        [Display(Name = "الجمعية الصحية الإنسانية")]
        charity3,

        [Display(Name = "جمعية رأفة رعاية الأيتام")]
        charity4,

        [Display(Name = "جمعية شكر لحفظ النعمة")]
        charity5,

        [Display(Name = "متطوع عام")]
        GeneralVolunteer
    }



}
