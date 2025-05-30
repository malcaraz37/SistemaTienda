using Microsoft.EntityFrameworkCore;
using SistemaTienda.Models;

namespace SistemaTienda.Data
{
    public class SistemaTiendaDbContext : DbContext
    {
        public SistemaTiendaDbContext(DbContextOptions<SistemaTiendaDbContext> options)
            : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
    }
}