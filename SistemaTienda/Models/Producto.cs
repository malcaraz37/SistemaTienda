using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SistemaTienda.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Range(0.01, 999999, ErrorMessage = "El precio debe estar entre 0.01 y 999999.")]
        [Precision(18, 2)]
        public decimal Precio { get; set; }

        [Range(0, 10000, ErrorMessage = "El stock debe estar entre 0 y 10,000 unidades.")]
        public int? Stock { get; set; }

        [Required(ErrorMessage = "Debes seleccionar un proveedor.")]
        public int? ProveedorId { get; set; }

        public Proveedor? Proveedor { get; set; }
    }
}