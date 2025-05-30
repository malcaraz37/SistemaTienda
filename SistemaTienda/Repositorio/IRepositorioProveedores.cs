using SistemaTienda.Models;

namespace SistemaTienda.Repositorio
{
    public interface IRepositorioProveedores
    {
        Task<List<Proveedor>> ObtenerTodos();
        Task Agregar(Proveedor proveedor);

        Task Actualizar(Proveedor proveedor);
        Task Eliminar(int id);

    }
} 