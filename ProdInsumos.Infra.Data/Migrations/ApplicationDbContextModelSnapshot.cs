﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProdInsumos.Infra.Data.Context;

#nullable disable

namespace ProdInsumos.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.27");

            modelBuilder.Entity("ProdInsumos.Domain.Entities.Alocado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ComputadorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataEntrega")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataRecebido")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Entregue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdComputador")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ComputadorId");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("Alocado");
                });

            modelBuilder.Entity("ProdInsumos.Domain.Entities.Computador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Disco")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("MemoriaRam")
                        .HasMaxLength(100000)
                        .HasColumnType("INTEGER");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Setor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("SistemaOperacional")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("TamanhoDisco")
                        .HasMaxLength(100000000)
                        .HasColumnType("INTEGER");

                    b.Property<int>("funcionarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("funcionarioId");

                    b.ToTable("Computador");
                });

            modelBuilder.Entity("ProdInsumos.Domain.Entities.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<bool>("Entrega")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Setor")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("ProdInsumos.Domain.Entities.Alocado", b =>
                {
                    b.HasOne("ProdInsumos.Domain.Entities.Computador", "Computador")
                        .WithMany("Alocado")
                        .HasForeignKey("ComputadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProdInsumos.Domain.Entities.Funcionario", "Funcionario")
                        .WithMany("Alocado")
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Computador");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("ProdInsumos.Domain.Entities.Computador", b =>
                {
                    b.HasOne("ProdInsumos.Domain.Entities.Funcionario", "funcionario")
                        .WithMany()
                        .HasForeignKey("funcionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("funcionario");
                });

            modelBuilder.Entity("ProdInsumos.Domain.Entities.Computador", b =>
                {
                    b.Navigation("Alocado");
                });

            modelBuilder.Entity("ProdInsumos.Domain.Entities.Funcionario", b =>
                {
                    b.Navigation("Alocado");
                });
#pragma warning restore 612, 618
        }
    }
}