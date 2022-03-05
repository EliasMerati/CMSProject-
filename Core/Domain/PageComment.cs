using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class PageComment
    {
        public PageComment()
        {

        }
        public int CommentId { get; set; }

        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [Display(Name = "آدرس وب سایت")]
        public string WebSite { get; set; }

        [Display(Name = "متن کامنت")]
        public string Comment { get; set; }

        [Display(Name = "تاریخ درج")]
        public string CommentDate { get; set; }


        #region Relations
        public virtual Page page { get; set; }
        #endregion

        
    }
}
