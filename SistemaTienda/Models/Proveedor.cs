using System.ComponentModel.DataAnnotations;

namespace SistemaTienda.Models
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la empresa es obligatorio.")]
        public string NombreEmpresa { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre del contacto es obligatorio.")]
        public string Contacto { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Teléfono no válido.")]
        public string Telefono { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Correo electrónico no válido.")]
        public string Correo { get; set; } = string.Empty;

        public List<Producto> Productos { get; set; } = new();
    }
}
