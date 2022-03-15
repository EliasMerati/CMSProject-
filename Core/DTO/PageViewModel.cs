using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO
{
   public class ShowPageViewModel
    {
        [Display(Name = "موضوع")]
        public string Title { get; set; }
        [Display(Name = "توضیح مختصر")]
        [DataType(DataType.MultilineText)]
        public string ShortDescription { get; set; }
        [Display(Name = "متن خبر")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        [Display(Name = "عکس")]
        public string ImageName { get; set; }
        [Display(Name = "اسلایدر")]
        public bool ShowSlider { get; set; }
        [Display(Name = "نام گروه")]
        public string GroupTitle { get; set; }
    }
}
