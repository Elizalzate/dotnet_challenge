using Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Persistance.Contexts;

public class DatabaseGestion : DbContext
{

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ClienteDetalles> ClienteDetalles { get; set; }
    public DbSet<Sucursal> Sucursales { get; set; }
    public DbSet<SucursalDetalles> SucursalDetalles { get; set; }

    public DbSet<TipoDocumento> TipoDocumentos { get; set; }
    public DatabaseGestion(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Cliente>().ToTable("Cliente");
        builder.Entity<Cliente>().HasKey(x => x.Documento);
        builder.Entity<Cliente>().Property(x => x.Documento).IsRequired();

        builder.Entity<ClienteDetalles>().ToTable("ClienteDetalles");
        builder.Entity<ClienteDetalles>().HasKey(x => x.Documento);
        builder.Entity<ClienteDetalles>().Property(x => x.Documento).IsRequired();
        builder.Entity<ClienteDetalles>().Property(x => x.TelefonoCelular).IsRequired().HasMaxLength(15);
        builder.Entity<ClienteDetalles>().Property(x => x.TelefonoFijo).IsRequired().HasMaxLength(12);


        builder.Entity<Sucursal>().ToTable("Sucursal");
        builder.Entity<Sucursal>().HasKey(x => x.CodigoSucursal);

        builder.Entity<TipoDocumento>().ToTable("TipoDocumento");
        builder.Entity<TipoDocumento>().HasKey(x => x.Id);

    }




    }
