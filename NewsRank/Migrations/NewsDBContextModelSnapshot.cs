﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsRank.Models;

namespace NewsRank.Migrations
{
    [DbContext(typeof(NewsDBContext))]
    partial class NewsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NewsRank.Models.TblNews", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("int(11)");

                    b.Property<string>("NewsContent")
                        .HasColumnName("NEWS_CONTENT")
                        .IsUnicode(false);

                    b.Property<int>("NewsRank")
                        .HasColumnName("news_rank")
                        .HasColumnType("int(11)");

                    b.Property<string>("NewsTitle")
                        .IsRequired()
                        .HasColumnName("news_title")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("NewsType")
                        .HasColumnName("news_type")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("NewsUrl")
                        .HasColumnName("news_url")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<DateTime?>("SubmitTime")
                        .HasColumnName("submit_time");

                    b.HasKey("Id");

                    b.ToTable("tbl_news","newsdb");
                });
#pragma warning restore 612, 618
        }
    }
}
