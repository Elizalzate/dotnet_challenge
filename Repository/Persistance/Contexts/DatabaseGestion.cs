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
    }




    }
