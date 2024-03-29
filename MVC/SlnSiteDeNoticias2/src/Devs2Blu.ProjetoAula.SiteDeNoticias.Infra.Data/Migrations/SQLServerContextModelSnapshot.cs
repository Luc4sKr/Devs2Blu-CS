﻿// <auto-generated />
using System;
using Devs2Blu.ProjetoAula.SiteDeNoticias.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Infra.Data.Migrations
{
    [DbContext(typeof(SQLServerContext))]
    partial class SQLServerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Destaque"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Programação"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Games"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Negócios"
                        });
                });

            modelBuilder.Entity("Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.Entities.News", b =>
                {
                    b.HasOne("Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.Entities.Category", "Category")
                        .WithMany("NewsList")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Devs2Blu.ProjetoAula.SiteDeNoticias.Domain.Entities.Category", b =>
                {
                    b.Navigation("NewsList");
                });
#pragma warning restore 612, 618
        }
    }
}
