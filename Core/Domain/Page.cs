using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Page
    {
        public Page()
        {

        }

        public int PageId { get; set; }

        

        [Display(Name = "تیتر خبر")]
        public string Title { get; set; }

        [Display(Name = "توضیح مختصر")]
        public string ShortDescription { get; set; }

        [Display(Name = "متن خبر")]
        public string Text { get; set; }

        [Display(Name = "بازدید")]
        public int Visit { get; set; }

        [Display(Name = "نام عکس")]
        public string ImageName { get; set; }

        [Display(Name = "اسلایدر")]
        public bool ShowSlider { get; set; }

        [Display(Name = "تاریخ درج خبر")]
        public string CreateDate { get; set; }

        #region Relations
        public virtual PageGroup pagegroup { get; set; }
        public virtual List<PageComment> pageComments { get; set; }
        #endregion
    }
}
