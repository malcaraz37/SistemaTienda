using SistemaTienda.Models;

namespace SistemaTienda.Repositorio
{
    public interface IRepositorioEntradas
    {
        Task<List<Entrada>> ObtenerTodas();
        Task Agregar(Entrada entrada);

        Task Actualizar(Entrada entrada);
        Task Eliminar(int id);

    }
}
