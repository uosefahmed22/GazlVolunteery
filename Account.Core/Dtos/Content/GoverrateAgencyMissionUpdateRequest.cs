using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account.Core.Enums;

namespace Account.Core.Dtos.Content
{
    public class GoverrateAgencyMissionUpdateRequest
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public CaseType CaseType { get; set; }
    }

}
