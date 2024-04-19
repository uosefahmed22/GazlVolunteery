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
        [Display(Name = "متطوع")]
        Volunteer,

        [Display(Name = "مسؤول وكالة المحافظة")]
        GoverrateAgencyMan
    }

}
