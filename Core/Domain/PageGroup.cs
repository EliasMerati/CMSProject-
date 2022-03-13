using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class PageGroup
    {
        public PageGroup()
        {

        }

        public int GroupId { get; set; }
        [Display(Name = "نام گروه")]
        public string GroupTitle { get; set; }

        #region Relations
        public virtual List<Page> Pages { get; set; }
        #endregion
    }
}
