using SistemaTienda.Models;

namespace SistemaTienda.Repositorio
{
    public interface IRepositorioProductos
    {
        Task<List<Producto>> ObtenerTodos();
        Task Agregar(Producto producto);
        Task Actualizar(Producto producto);
        Task Eliminar(int id);
    }
}