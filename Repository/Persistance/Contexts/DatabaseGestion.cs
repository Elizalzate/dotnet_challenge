using Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Persistance.Contexts;

public class DatabaseGestion : DbContext
{

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ClienteDetalles> ClienteDetalles { get; set; }

    public DbSet<ClienteSucursal> ClienteSucursal { get; set; }
    public DbSet<Sucursal> Sucursales { get; set; }
    public DbSet<SucursalDetalles> SucursalDetalles { get; set; }

    public DbSet<TipoDocumento> TipoDocumento { get; set; }

    public DbSet<TipoCliente> TipoCliente { get; set; }
    public DatabaseGestion(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=database.db",
                b => b.MigrationsAssembly("Repository")); 
        }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Cliente>().ToTable("Cliente");
        builder.Entity<Cliente>().HasOne(e => e.ClienteDetalles).WithOne(e => e.Cliente).HasForeignKey<ClienteDetalles>(e => e.Documento);
    
        builder.Entity<Cliente>().HasKey(x => x.Documento);
        builder.Entity<Cliente>().Property(x => x.Documento).IsRequired();

        builder.Entity<ClienteDetalles>().ToTable("ClienteDetalles");
        builder.Entity<ClienteDetalles>().HasKey(x => x.Documento);
        builder.Entity<ClienteDetalles>().Property(x => x.Documento).IsRequired();
        builder.Entity<ClienteDetalles>().Property(x => x.TelefonoCelular).IsRequired().HasMaxLength(15);
        builder.Entity<ClienteDetalles>().Property(x => x.TelefonoFijo).IsRequired().HasMaxLength(12);

        builder.Entity<ClienteSucursal>().ToTable("ClienteSucursal");


        builder.Entity<Sucursal>().ToTable("Sucursal");
        builder.Entity<Sucursal>().HasKey(x => x.CodigoSucursal);
        builder.Entity<Sucursal>().HasOne(e => e.SucursalDetalles).WithOne(e => e.Sucursal).HasForeignKey<SucursalDetalles>(e => e.CodigoSucursal);

        builder.Entity<SucursalDetalles>().ToTable("Sucursal");
        builder.Entity<SucursalDetalles>().HasKey(x => x.CodigoSucursal);

        builder.Entity<TipoDocumento>().ToTable("TipoDocumento");
        builder.Entity<TipoDocumento>().HasKey(x => x.Id);

        builder.Entity<TipoCliente>().ToTable("TipoCliente");
        builder.Entity<TipoCliente>().HasKey(x => x.Id);

    }




    }
