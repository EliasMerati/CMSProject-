using Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class PageConfig : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.HasKey(p=>p.PageId);
            builder.Property(p=>p.ImageName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(p => p.ShortDescription)
                .IsRequired()
                .HasMaxLength(350);
            builder.Property(p=>p.CreateDate)
                .IsRequired()
                .HasMaxLength(11);
            builder.Property(p => p.Text)
                .IsRequired();
            builder.HasOne(p => p.pagegroup)
                .WithMany(p => p.Pages);
            builder.HasMany(p => p.pageComments)
            .WithOne(p => p.page);
                
        }
    }
}
