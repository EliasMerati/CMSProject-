using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IPageRepository
    {
        IEnumerable<Page> GetPages();
        Page GetPageById(int pageid);
        bool InsertPage(Domain.Page page);
        bool UpdatePage(Domain.Page page); 
        bool DeletePage(Domain.Page page);
        bool DeletePage(int pageid);
        void Save();
    }
}
