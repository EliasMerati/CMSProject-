using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IPageCommentRepository
    {
        IEnumerable<PageComment> GetPageComments();
        PageComment GetPageCommentById(int pagecommentid);
        bool InsertPageComment(PageComment pagecomment);
        bool UpdatePageComment(PageComment pagecomment);
        bool DeletePageComment(PageComment pagecomment);
        bool DeletePageComment(int pagecommentid);
        void Save();
    }
}
