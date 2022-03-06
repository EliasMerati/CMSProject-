using Core.Domain;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Context
{
    public class CmsContext : DbContext
    {

        public CmsContext(DbContextOptions Options) : base(Options)
        {

        }
        public DbSet<Page> Page { get; set; }
        public DbSet<PageComment> pageComment{ get; set; }
        public DbSet<PageGroup> pageGroup { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new pageGroup());
            modelBuilder.ApplyConfiguration(new page());
            modelBuilder.ApplyConfiguration(new pagecomment());
        }
    }
}
