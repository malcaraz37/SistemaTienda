using System.ComponentModel.DataAnnotations;

namespace SistemaTienda.Models
{
    public class Entrada
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debes seleccionar un producto.")]
        public int? ProductoId { get; set; }
        public Producto? Producto { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatoria.")]
        [Range(1, 100000, ErrorMessage = "La cantidad debe ser mayor a 0.")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        public DateTime? Fecha { get; set; }

        [StringLength(100, ErrorMessage = "La descripción no puede tener más de 100 caracteres.")]
        public string Descripcion { get; set; } = string.Empty;
    }
}
