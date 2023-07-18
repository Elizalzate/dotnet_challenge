using Core;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Repository.Persistance.Contexts;

public class DatabaseGestion : DbContext
{

    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<ClienteDetalles> ClienteDetalles { get; set; }

    public DbSet<ClienteSucursal> Clienteucursal { get; set; }
    /*public DbSet<Sucursal> Sucursales { get; set; }
    public DbSet<SucursalDetalles> SucursalDetalles { get; set; }*/

    public DbSet<TipoDocumento> TipoDocumento { get; set; }

    public DbSet<TipoCliente> TipoCliente { get; set; }
    public DatabaseGestion(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Cliente>().HasKey(c => c.Documento);
        builder.Entity<ClienteDetalles>().HasKey(c => c.Documento);
        builder.Entity<ClienteSucursal>().HasNoKey();
        builder.Entity<Sucursal>().HasKey(c => c.CodigoSucursal);
        builder.Entity<SucursalDetalles>().HasKey(c => c.CodigoSucursal);
        builder.Entity<TipoDocumento>().HasKey(c => c.Id);
        builder.Entity<TipoCliente>().HasKey(c => c.Id);

        // Configure the one-to-many relationship using Fluent API
        builder.Entity<Cliente>()
            .HasOne(e => e.Detalles)
            .WithOne(e => e.Cliente)
            .HasForeignKey<ClienteDetalles>("Documento");

        builder.Entity<Sucursal>()
            .HasOne(e => e.SucursalDetalles)
            .WithOne(e => e.Sucursal)
            .HasForeignKey<SucursalDetalles>("CodigoSucursal");
    }




}
