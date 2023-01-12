﻿// <auto-generated />
using Devs2Blu.ProjetoAula.SiteDeNoticias.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Devs2Blu.ProjetoAula.SiteDeNoticias.Migrations
{
    [DbContext(typeof(ContextDatabase))]
    partial class ContextDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Devs2Blu.ProjetoAula.SiteDeNoticias.Models.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Política"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Esportes"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Entretenimento"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Brasil"
                        });
                });

            modelBuilder.Entity("Devs2Blu.ProjetoAula.SiteDeNoticias.Models.Entities.Noticia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int")
                        .HasColumnName("categoriaId");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descricao");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("titulo");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("noticias");
                });

            modelBuilder.Entity("Devs2Blu.ProjetoAula.SiteDeNoticias.Models.Entities.Noticia", b =>
                {
                    b.HasOne("Devs2Blu.ProjetoAula.SiteDeNoticias.Models.Entities.Categoria", "Categoria")
                        .WithMany("Noticias")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Devs2Blu.ProjetoAula.SiteDeNoticias.Models.Entities.Categoria", b =>
                {
                    b.Navigation("Noticias");
                });
#pragma warning restore 612, 618
        }
    }
}