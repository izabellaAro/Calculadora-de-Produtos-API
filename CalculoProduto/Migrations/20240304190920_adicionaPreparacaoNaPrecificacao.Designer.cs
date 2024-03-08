﻿// <auto-generated />
using CalculoProduto.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalculoProduto.Migrations
{
    [DbContext(typeof(ProdutoContext))]
    [Migration("20240304190920_adicionaPreparacaoNaPrecificacao")]
    partial class adicionaPreparacaoNaPrecificacao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CalculoProduto.Entities.InsumoIndireto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Especificao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("InsumoIndireto");
                });

            modelBuilder.Entity("CalculoProduto.Entities.InsumoPreparacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("InsumoIndiretoId")
                        .HasColumnType("int");

                    b.Property<int>("PreparacaoId")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("InsumoIndiretoId");

                    b.HasIndex("PreparacaoId");

                    b.ToTable("InsumoPreparacao");
                });

            modelBuilder.Entity("CalculoProduto.Entities.ItemPreparacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MateriaPrimaId")
                        .HasColumnType("int");

                    b.Property<int>("PreparacaoId")
                        .HasColumnType("int");

                    b.Property<double>("Qnt")
                        .HasColumnType("double");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("MateriaPrimaId");

                    b.HasIndex("PreparacaoId");

                    b.ToTable("ItemPreparacao");
                });

            modelBuilder.Entity("CalculoProduto.Entities.MateriaPrima", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Qnts")
                        .HasColumnType("double");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("MateriaPrima");
                });

            modelBuilder.Entity("CalculoProduto.Entities.Precificacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("CustoInsumo")
                        .HasColumnType("double");

                    b.Property<double>("CustoMO")
                        .HasColumnType("double");

                    b.Property<double>("CustoMP")
                        .HasColumnType("double");

                    b.Property<double>("PercentualLucro")
                        .HasColumnType("double");

                    b.Property<int>("PreparacaoId")
                        .HasColumnType("int");

                    b.Property<double>("TotalCusto")
                        .HasColumnType("double");

                    b.Property<double>("TotalVenda")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("PreparacaoId")
                        .IsUnique();

                    b.ToTable("Precificacao");
                });

            modelBuilder.Entity("CalculoProduto.Entities.Preparacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Preparacao");
                });

            modelBuilder.Entity("CalculoProduto.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("CalculoProduto.Entities.InsumoPreparacao", b =>
                {
                    b.HasOne("CalculoProduto.Entities.InsumoIndireto", "Insumo")
                        .WithMany()
                        .HasForeignKey("InsumoIndiretoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalculoProduto.Entities.Preparacao", "Preparacao")
                        .WithMany("InsumosPreparacao")
                        .HasForeignKey("PreparacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insumo");

                    b.Navigation("Preparacao");
                });

            modelBuilder.Entity("CalculoProduto.Entities.ItemPreparacao", b =>
                {
                    b.HasOne("CalculoProduto.Entities.MateriaPrima", "MateriaPrima")
                        .WithMany()
                        .HasForeignKey("MateriaPrimaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalculoProduto.Entities.Preparacao", "Preparacao")
                        .WithMany("ItensPreparacao")
                        .HasForeignKey("PreparacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MateriaPrima");

                    b.Navigation("Preparacao");
                });

            modelBuilder.Entity("CalculoProduto.Entities.Precificacao", b =>
                {
                    b.HasOne("CalculoProduto.Entities.Preparacao", "Preparacao")
                        .WithOne("Precificacao")
                        .HasForeignKey("CalculoProduto.Entities.Precificacao", "PreparacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Preparacao");
                });

            modelBuilder.Entity("CalculoProduto.Entities.Preparacao", b =>
                {
                    b.HasOne("CalculoProduto.Entities.Produto", "Produto")
                        .WithMany("Preparacoes")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("CalculoProduto.Entities.Preparacao", b =>
                {
                    b.Navigation("InsumosPreparacao");

                    b.Navigation("ItensPreparacao");

                    b.Navigation("Precificacao")
                        .IsRequired();
                });

            modelBuilder.Entity("CalculoProduto.Entities.Produto", b =>
                {
                    b.Navigation("Preparacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
