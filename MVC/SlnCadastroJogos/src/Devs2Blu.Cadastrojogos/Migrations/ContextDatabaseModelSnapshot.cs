﻿// <auto-generated />
using Devs2Blu.Cadastrojogos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Devs2Blu.Cadastrojogos.Migrations
{
    [DbContext(typeof(ContextDatabase))]
    partial class ContextDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Devs2Blu.Cadastrojogos.Models.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("empresas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Activision"
                        },
                        new
                        {
                            Id = 2,
                            Nome = " Rockstar Games"
                        });
                });

            modelBuilder.Entity("Devs2Blu.Cadastrojogos.Models.Entities.Jogo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int")
                        .HasColumnName("EmpresaId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<double>("Preco")
                        .HasColumnType("float")
                        .HasColumnName("preco");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("jogos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmpresaId = 1,
                            Nome = "Call of Duty",
                            Preco = 80.0
                        },
                        new
                        {
                            Id = 2,
                            EmpresaId = 2,
                            Nome = "Grand Theft Auto V",
                            Preco = 100.0
                        });
                });

            modelBuilder.Entity("Devs2Blu.Cadastrojogos.Models.Entities.Jogo", b =>
                {
                    b.HasOne("Devs2Blu.Cadastrojogos.Models.Entities.Empresa", "Empresa")
                        .WithMany("Jogos")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Devs2Blu.Cadastrojogos.Models.Entities.Empresa", b =>
                {
                    b.Navigation("Jogos");
                });
#pragma warning restore 612, 618
        }
    }
}
