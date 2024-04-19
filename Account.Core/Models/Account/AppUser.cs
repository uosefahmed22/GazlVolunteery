using Account.Core.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Models.Account
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public CharitiesEnum? Charities { get; set; }
        public GoverrateAgancyEnum? GoverrateAgancy { get; set; }

    }
}
