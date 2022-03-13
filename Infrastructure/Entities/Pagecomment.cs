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
    public class pagecomment : IEntityTypeConfiguration<PageComment>
    {
        public void Configure(EntityTypeBuilder<PageComment> builder)
        {
            builder.HasKey(p => p.CommentId);
            builder.Property(p => p.Comment)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(500);
            builder.Property(p=>p.CommentDate)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(11);
            builder.Property(p=>p.Email)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(150);
            builder.Property(p => p.Name)
               .IsRequired()
               .HasColumnType("nvarchar")
               .HasMaxLength(150);
            builder.Property(p => p.WebSite)
                .HasColumnType("nvarchar")
               .HasMaxLength(150);

        }
    }
}
