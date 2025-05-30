using Microsoft.EntityFrameworkCore;
using SistemaTienda.Data;
using SistemaTienda.Models;

namespace SistemaTienda.Repositorio
{
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly SistemaTiendaDbContext _context;

        public RepositorioProductos(SistemaTiendaDbContext context)
        {
            _context = context;
        }

        public async Task<List<Producto>> ObtenerTodos()
        {
            return await _context.Productos.Include(p => p.Proveedor).ToListAsync();
        }

        public async Task Agregar(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
        }
    

            public async Task Actualizar(Producto producto)
        {
            var existente = await _context.Productos.FindAsync(producto.Id);
            if (existente is not null)
            {
                existente.Nombre = producto.Nombre;
                existente.Precio = producto.Precio;
                existente.Stock = producto.Stock;
                existente.ProveedorId = producto.ProveedorId;

                await _context.SaveChangesAsync();
            }
        }

        public async Task Eliminar(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto is not null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
            }
        }
    }
   }