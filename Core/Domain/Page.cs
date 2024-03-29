﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Display(Name ="موضوع")]
        public string Title { get; set; }
        [Display(Name = "توضیح مختصر")]
        [DataType(DataType.MultilineText)]
        public string ShortDescription { get; set; }
        [Display(Name = "متن خبر")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        [Display(Name = "بازدید")]
        public int Visit { get; set; }
        [Display(Name = "عکس")]
        public string ImageName { get; set; }
        [Display(Name = "اسلایدر")]
        public bool ShowSlider { get; set; }
        [Display(Name = "تاریخ درج خبر")]
        public string CreateDate { get; set; }

        #region Relations
        [ForeignKey("GroupIdFK")]
        public virtual PageGroup pagegroup { get; set; }
        public virtual List<PageComment> pageComments { get; set; }
        #endregion
    }
}
