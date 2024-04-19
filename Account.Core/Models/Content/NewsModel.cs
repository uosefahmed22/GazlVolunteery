using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Models.Content
{
    public class NewsModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "المحتوى مطلوب")]
        public string Content { get; set; }

        [Required(ErrorMessage = "رابط الصورة مطلوب")]
        [Url(ErrorMessage = "تنسيق رابط غير صالح")]
        public string PictureUrl { get; set; }
    }

}
