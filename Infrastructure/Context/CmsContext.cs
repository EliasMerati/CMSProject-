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
        public DbSet<Page> Pages { get; set; }
        public DbSet<PageComment> pageComments { get; set; }
        public DbSet<PageGroup> pageGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PageGroupConfig());
            modelBuilder.ApplyConfiguration(new PageConfig());
            modelBuilder.ApplyConfiguration(new PageCommentConfig());
        }
    }
}
