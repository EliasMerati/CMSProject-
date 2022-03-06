
using Core;
using Core.Domain;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class PageRepository : IPageRepository , IDisposable
    {
        private CmsContext _db;
        public PageRepository(CmsContext db)
        {
            _db = db;
        }
        public IEnumerable<Page> GetPages()
        {
            return _db.Page.ToList();
        }
        public Page GetPageById(int pageid)
        {
            return _db.Page.Find(pageid);
        }

        public bool InsertPage(Page page)
        {
            try
            {
                _db.Entry(page).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                Save();
                Dispose();
                return true;
                
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool UpdatePage(Page page)
        {
            try
            {
                _db.Entry(page).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Save();
                Dispose();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool DeletePage(Page page)
        {
            try
            {
                _db.Entry(page).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                Save();
                Dispose();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeletePage(int pageid)
        {
            try
            {
                var page = GetPageById(pageid);
                DeletePage(page);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
