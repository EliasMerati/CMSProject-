﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(CmsContext))]
    partial class CmsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Core.Domain.Page", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreateDate")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<bool>("ShowSlider")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Visit")
                        .HasColumnType("int");

                    b.Property<int?>("pagegroupGroupId")
                        .HasColumnType("int");

                    b.HasKey("PageId");

                    b.HasIndex("pagegroupGroupId");

                    b.ToTable("Page");
                });

            modelBuilder.Entity("Core.Domain.PageComment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CommentDate")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("PageId")
                        .HasColumnType("int");

                    b.Property<string>("WebSite")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("CommentId");

                    b.HasIndex("PageId");

                    b.ToTable("pageComment");
                });

            modelBuilder.Entity("Core.Domain.PageGroup", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GroupTitle")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("GroupId");

                    b.ToTable("pageGroup");
                });

            modelBuilder.Entity("Core.Domain.Page", b =>
                {
                    b.HasOne("Core.Domain.PageGroup", "pagegroup")
                        .WithMany("Pages")
                        .HasForeignKey("pagegroupGroupId");

                    b.Navigation("pagegroup");
                });

            modelBuilder.Entity("Core.Domain.PageComment", b =>
                {
                    b.HasOne("Core.Domain.Page", "page")
                        .WithMany("pageComments")
                        .HasForeignKey("PageId");

                    b.Navigation("page");
                });

            modelBuilder.Entity("Core.Domain.Page", b =>
                {
                    b.Navigation("pageComments");
                });

            modelBuilder.Entity("Core.Domain.PageGroup", b =>
                {
                    b.Navigation("Pages");
                });
#pragma warning restore 612, 618
        }
    }
}
