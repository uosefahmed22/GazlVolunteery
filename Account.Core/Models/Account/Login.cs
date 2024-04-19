using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Models.Account
{
    using System.ComponentModel.DataAnnotations;

    public class Login
    {
        [EmailAddress(ErrorMessage = "البريد الإلكتروني غير صحيح")]
        [Required(ErrorMessage = "البريد الإلكتروني مطلوب")]
        public string Email { get; set; }

        [Required(ErrorMessage = "كلمة المرور مطلوبة")]
        public string Password { get; set; }
    }

}
