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
        charity1,//=>0

        [Display(Name = "جمعية الإسكان التنموي")]
        charity2,//=>1

        [Display(Name = "الجمعية الصحية الإنسانية")]
        charity3,//=>2

        [Display(Name = "جمعية رأفة رعاية الأيتام")]
        charity4,//=>3

        [Display(Name = "جمعية شكر لحفظ النعمة")]
        charity5,//=>4

        [Display(Name = "متطوع عام")]
        GeneralVolunteer,//=>5

        Null//=>6
    }



}
