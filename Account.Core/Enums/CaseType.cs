using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum CaseType
    {
        [Display(Name = "لم يتم المعالجة")]
        Red,

        [Display(Name = "تم المعالجة")]
        Green,

        [Display(Name = "جاري المعالجةالان ")]
        Orange
    }

}
