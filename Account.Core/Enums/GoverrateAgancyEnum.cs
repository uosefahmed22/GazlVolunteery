using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Enums
{
    public enum GoverrateAgancyEnum
    {
        [Display(Name = "محافظة بيشة")]
        GoverrateAgancy1, //=>0

        [Display(Name = "وزارة الصحة")]
        GoverrateAgancy2,//=>1

        [Display(Name = "وزارة الموارد البشرية والتنمية الاجتماعية")]
        GoverrateAgancy3,//=>2

        [Display(Name = "وزارة العدل")]
        GoverrateAgancy4,//=>3

        [Display(Name = "وزارة الشؤون البلدية والقروية والإسكان")]
        GoverrateAgancy5,//=>4

        Null//=>5
    }

}
