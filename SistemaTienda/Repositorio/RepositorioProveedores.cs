using Microsoft.EntityFrameworkCore;
using SistemaTienda.Data;
using SistemaTienda.Models;

namespace SistemaTienda.Repositorio
{
    public class RepositorioProveedores : IRepositorioProveedores
    {
        private readonly SistemaTiendaDbContext _context;

        public RepositorioProveedores(SistemaTiendaDbContext context)
        {
            _context = context;
        }

        public async Task<List<Proveedor>> ObtenerTodos()
        {
            return await _context.Proveedores.ToListAsync();
        }

        public async Task Agregar(Proveedor proveedor)
        {
            _context.Proveedores.Add(proveedor);
            await _context.SaveChangesAsync();
        }
        public async Task Actualizar(Proveedor proveedor)
        {
            var existente = await _context.Proveedores.FindAsync(proveedor.Id);
            if (existente is not null)
            {
                existente.NombreEmpresa = proveedor.NombreEmpresa;
                existente.Contacto = proveedor.Contacto;
                existente.Telefono = proveedor.Telefono;
                existente.Correo = proveedor.Correo;

                await _context.SaveChangesAsync();
            }
        }

        public async Task Eliminar(int id)
        {
            var proveedor = await _context.Proveedores.FindAsync(id);
            if (proveedor is not null)
            {
                _context.Proveedores.Remove(proveedor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
