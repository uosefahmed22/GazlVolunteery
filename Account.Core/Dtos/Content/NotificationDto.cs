using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Dtos.Content
{
    public class NotificationDto
    {
        [Required]
        [Display(Name = "الرسالة")]
        public string Message { get; set; }

        [Display(Name = "التاريخ")]
        public DateTime Date { get; set; }

        [Display(Name = "تم القراءة")]
        public bool IsRead { get; set; }
    }

}
