﻿// <auto-generated />
using System;
using Condominiosdotcom.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Condominiosdotcom.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220527210806_changepago")]
    partial class changepago
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Condominiosdotcom.Api.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Condominiosdotcom.Api.Models.Concepto", b =>
                {
                    b.Property<int>("ConceptoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Elconcepto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Recurrencia")
                        .HasColumnType("bit");

                    b.HasKey("ConceptoID");

                    b.ToTable("Concepto");
                });

            modelBuilder.Entity("Condominiosdotcom.Api.Models.Condominio", b =>
                {
                    b.Property<int>("CondominioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<int>("ResidencialID")
                        .HasColumnType("int");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.Property<string>("Vivienda")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CondominioID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("ResidencialID");

                    b.ToTable("Condominio");
                });

            modelBuilder.Entity("Condominiosdotcom.Api.Models.Cuotas", b =>
                {
                    b.Property<int>("CuotaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<int>("ConceptoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<int>("Mora")
                        .HasColumnType("int");

                    b.Property<int>("Pendiente")
                        .HasColumnType("int");

                    b.HasKey("CuotaID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("ConceptoID");

                    b.ToTable("Cuotas");
                });

            modelBuilder.Entity("Condominiosdotcom.Api.Models.Pagos", b =>
                {
                    b.Property<int>("PagoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteID")
                        .HasColumnType("int");

                    b.Property<int?>("ConceptoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<int>("Mora")
                        .HasColumnType("int");

                    b.Property<int>("Pendiente")
                        .HasColumnType("int");

                    b.HasKey("PagoID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("ConceptoID");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Condominiosdotcom.Api.Models.Residencial", b =>
                {
                    b.Property<int>("ResidencialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreResidencial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResidencialID");

                    b.ToTable("Residencial");
                });

            modelBuilder.Entity("Condominiosdotcom.Api.Models.Condominio", b =>
                {
                    b.HasOne("Condominiosdotcom.Api.Models.Cliente", "ClienteE")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Condominiosdotcom.Api.Models.Residencial", "ResidencialE")
                        .WithMany()
                        .HasForeignKey("ResidencialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClienteE");

                    b.Navigation("ResidencialE");
                });

            modelBuilder.Entity("Condominiosdotcom.Api.Models.Cuotas", b =>
                {
                    b.HasOne("Condominiosdotcom.Api.Models.Cliente", "ClienteE")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Condominiosdotcom.Api.Models.Concepto", "ConceptoE")
                        .WithMany()
                        .HasForeignKey("ConceptoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClienteE");

                    b.Navigation("ConceptoE");
                });

            modelBuilder.Entity("Condominiosdotcom.Api.Models.Pagos", b =>
                {
                    b.HasOne("Condominiosdotcom.Api.Models.Cliente", "ClienteE")
                        .WithMany()
                        .HasForeignKey("ClienteID");

                    b.HasOne("Condominiosdotcom.Api.Models.Concepto", "ConceptoE")
                        .WithMany()
                        .HasForeignKey("ConceptoID");

                    b.Navigation("ClienteE");

                    b.Navigation("ConceptoE");
                });
#pragma warning restore 612, 618
        }
    }
}
