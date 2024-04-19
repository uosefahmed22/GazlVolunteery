using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Models.Content
{
    public class Notification
    {
        public int Id { get; set; }

        [Display(Name = "الرسالة")]
        [Required(ErrorMessage = "يجب إدخال الرسالة")]
        public string Message { get; set; }

        [Display(Name = "التاريخ")]
        [Required(ErrorMessage = "يجب إدخال التاريخ")]
        public DateTime Date { get; set; }

        [Display(Name = "تم القراءة")]
        public bool IsRead { get; set; }
    }

}
