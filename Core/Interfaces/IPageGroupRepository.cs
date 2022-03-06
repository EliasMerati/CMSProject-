using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IPageGroupRepository
    {
        IEnumerable<PageGroup> GetPageGroups();
        PageGroup GetPageGroupeById(int pagegroupid);
        bool InsertPageGroup(PageGroup pagegroup);
        bool UpdatePageGroup(PageGroup pagegroup);
        bool DeletePageGroup(PageGroup pagegroup);
        bool DeletePageGroup(int pagegroupid);
        void Save();
    }
}
