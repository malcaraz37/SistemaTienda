using Microsoft.EntityFrameworkCore;
using SistemaTienda.Data;
using SistemaTienda.Models;

namespace SistemaTienda.Repositorio
{
    public class RepositorioEntradas : IRepositorioEntradas
    {
        private readonly SistemaTiendaDbContext _context;

        public RepositorioEntradas(SistemaTiendaDbContext context)
        {
            _context = context;
        }

        public async Task<List<Entrada>> ObtenerTodas()
        {
            return await _context.Entradas
                .Include(e => e.Producto)    
                    .ThenInclude(p => p.Proveedor)
                .ToListAsync();
        }

        public async Task Agregar(Entrada entrada)
        {
            _context.Entradas.Add(entrada);
            await _context.SaveChangesAsync();
        }

        public async Task Actualizar(Entrada entrada)
        {
            _context.Entradas.Update(entrada);
            await _context.SaveChangesAsync();
        }

        public async Task Eliminar(int id)
        {
            var entrada = await _context.Entradas.FindAsync(id);
            if (entrada != null)
            {
                _context.Entradas.Remove(entrada);
                await _context.SaveChangesAsync();
            }
        }
    }
}