using Core.Domain;
using Core.Interfaces;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class PageCommentRepository : IPageCommentRepository, IDisposable
    {
        private CmsContext _db;
        public PageCommentRepository(CmsContext db)
        {
            _db = db;
        }


        public IEnumerable<PageComment> GetPageComments()
        {
            return _db.pageComment.ToList();
        }

        public PageComment GetPageCommentById(int pagecommentid)
        {
            return _db.pageComment.Find(pagecommentid);
        }

        public bool InsertPageComment(PageComment pagecomment)
        {
            try
            {
                _db.Entry(pagecomment).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                Save();
                Dispose();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdatePageComment(PageComment pagecomment)
        {
            try
            {
                _db.Entry(pagecomment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Save();
                Dispose();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeletePageComment(PageComment pagecomment)
        {
            try
            {
                _db.Entry(pagecomment).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                Save();
                Dispose();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeletePageComment(int pagecommentid)
        {
            try
            {
                var pagecomment = GetPageCommentById(pagecommentid);
                DeletePageComment(pagecomment);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }


    }
}
