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
    public class pageGroup : IEntityTypeConfiguration<PageGroup>
    {
        public void Configure(EntityTypeBuilder<PageGroup> builder)
        {
            builder.HasKey(p=>p.GroupId);      
            builder.Property(p=>p.GroupTitle)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
