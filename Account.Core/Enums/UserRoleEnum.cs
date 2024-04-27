using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Enums
{
    public enum UserRoleEnum
    {
        [Display(Name = "زائر")]
        Visitor,//==> 0

        [Display(Name = "جهة حكومية")]
        GovernmentAgency,//==> 1

        [Display(Name = "جهة أهلية")]
        CivilSocietyOrganization,//==> 2

        [Display(Name = "قطاع خاص")]
        PrivateSector//==> 3
    }

}
