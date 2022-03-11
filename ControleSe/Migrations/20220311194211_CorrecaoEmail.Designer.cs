﻿// <auto-generated />
using System;
using ControleSe.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleSe.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220311194211_CorrecaoEmail")]
    partial class CorrecaoEmail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleSe.Entidade.Cofre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("TotalCobre")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Cofre");
                });

            modelBuilder.Entity("ControleSe.Entidade.Divida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataPagamento")
                        .HasColumnType("date");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("date");

                    b.Property<string>("Descricao")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit");

                    b.Property<int>("TipoDivida")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .HasDatabaseName("index_nome_divida");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Divida");
                });

            modelBuilder.Entity("ControleSe.Entidade.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnderecoEmail")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Porta")
                        .HasColumnType("int");

                    b.Property<string>("SenhaEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Smtp")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Ssl")
                        .HasColumnType("bit");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Email");
                });

            modelBuilder.Entity("ControleSe.Entidade.Entrada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("date");

                    b.Property<string>("Observacao")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorEntrada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.HasKey("Id");

                    b.HasIndex("DataEntrada")
                        .HasDatabaseName("index_dataEntrada_entrada");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Entrada");
                });

            modelBuilder.Entity("ControleSe.Entidade.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<bool>("EhAdm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SenhaAcesso")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UsuarioAcesso")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .HasDatabaseName("index_nome_usuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ControleSe.Entidade.Cofre", b =>
                {
                    b.HasOne("ControleSe.Entidade.Usuario", "Usuario")
                        .WithOne("Cofre")
                        .HasForeignKey("ControleSe.Entidade.Cofre", "UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ControleSe.Entidade.Divida", b =>
                {
                    b.HasOne("ControleSe.Entidade.Usuario", "Usuario")
                        .WithMany("Dividas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ControleSe.Entidade.Email", b =>
                {
                    b.HasOne("ControleSe.Entidade.Usuario", "Usuario")
                        .WithOne("Email")
                        .HasForeignKey("ControleSe.Entidade.Email", "UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ControleSe.Entidade.Entrada", b =>
                {
                    b.HasOne("ControleSe.Entidade.Usuario", "Usuario")
                        .WithMany("Entradas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ControleSe.Entidade.Usuario", b =>
                {
                    b.Navigation("Cofre");

                    b.Navigation("Dividas");

                    b.Navigation("Email");

                    b.Navigation("Entradas");
                });
#pragma warning restore 612, 618
        }
    }
}
