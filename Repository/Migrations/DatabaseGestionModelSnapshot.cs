﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Persistance.Contexts;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(DatabaseGestion))]
    partial class DatabaseGestionModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("Core.Cliente", b =>
                {
                    b.Property<string>("Documento")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdTipoCliente")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdTipoDocumento")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("TEXT");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("TEXT");

                    b.HasKey("Documento");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Core.ClienteDetalles", b =>
                {
                    b.Property<string>("Documento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefonoCelular")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefonoFijo")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.HasKey("Documento");

                    b.ToTable("ClienteDetalles", (string)null);
                });

            modelBuilder.Entity("Core.Sucursal", b =>
                {
                    b.Property<string>("CodigoSucursal")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodigoVendedor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("CupoCredito")
                        .HasColumnType("REAL");

                    b.Property<string>("NombreSucursal")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CodigoSucursal");

                    b.ToTable("Sucursal", (string)null);
                });

            modelBuilder.Entity("Core.SucursalDetalles", b =>
                {
                    b.Property<string>("CodigoSucursal")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefonoCelular")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefonoFijo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CodigoSucursal");

                    b.ToTable("Sucursal", (string)null);
                });

            modelBuilder.Entity("Core.TipoCliente", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TipoCliente", (string)null);
                });

            modelBuilder.Entity("Core.TipoDocumento", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CodigoDian")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TipoDocumento", (string)null);
                });

            modelBuilder.Entity("Core.ClienteDetalles", b =>
                {
                    b.HasOne("Core.Cliente", "Cliente")
                        .WithOne("ClienteDetalles")
                        .HasForeignKey("Core.ClienteDetalles", "Documento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Core.SucursalDetalles", b =>
                {
                    b.HasOne("Core.Sucursal", "Sucursal")
                        .WithOne("SucursalDetalles")
                        .HasForeignKey("Core.SucursalDetalles", "CodigoSucursal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("Core.Cliente", b =>
                {
                    b.Navigation("ClienteDetalles");
                });

            modelBuilder.Entity("Core.Sucursal", b =>
                {
                    b.Navigation("SucursalDetalles")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}