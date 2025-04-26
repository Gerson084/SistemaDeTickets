using System.ComponentModel.DataAnnotations;

namespace SistemaDeTickets.Models
{
    public class Usuarios
    {
        [Key]
        public int id_usuario { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string apellido { get; set; }

        [Required]
        [StringLength(150)]
        public string correo { get; set; }

        [Required]
        [StringLength(255)]
        public string clave { get; set; }

        [Required]
        [StringLength(20)]
        public string rol { get; set; }

    }
}
