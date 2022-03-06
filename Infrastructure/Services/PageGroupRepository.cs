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
    public class PageGroupRepository : IPageGroupRepository , IDisposable
    {
        private CmsContext _db;
        public PageGroupRepository(CmsContext db)
        {
            _db = db;
        }

        public IEnumerable<PageGroup> GetPageGroups()
        {
            return _db.pageGroup.ToList();
        }

        public PageGroup GetPageGroupeById(int pagegroupid)
        {
            return _db.pageGroup.Find(pagegroupid);
        }

        public bool InsertPageGroup(PageGroup pagegroup)
        {
            try
            {
                _db.Entry(pagegroup).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                Save();
                Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdatePageGroup(PageGroup pagegroup)
        {
            try
            {
                _db.Entry(pagegroup).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Save();
                Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletePageGroup(PageGroup pagegroup)
        {
            try
            {
                _db.Entry(pagegroup).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                Save();
                Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletePageGroup(int pagegroupid)
        {
            try
            {
                var pagegroup = GetPageGroupeById(pagegroupid);
                DeletePageGroup(pagegroup);
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
