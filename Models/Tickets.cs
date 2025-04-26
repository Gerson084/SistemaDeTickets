using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeTickets.Models
{
    public class Tickets
    {
        [Key]
        public int id_ticket { get; set; }

        [Required]
        public int id_usuario_cliente { get; set; }

        public int? id_usuario_agente { get; set; }

        [Required]
        [StringLength(255)]
        public string titulo { get; set; }

        [Required]
        public string descripcion { get; set; }

        [Required]
        [StringLength(10)]
        public string prioridad { get; set; }

        [Required]
        [StringLength(20)]
        public string estado { get; set; }

        [Required]
        public DateTime fecha_creacion { get; set; }

        public DateTime? fecha_resolucion { get; set; }

        // Relaciones
        [ForeignKey("id_usuario_cliente")]
        public Usuarios UsuarioCliente { get; set; }

        [ForeignKey("id_usuario_agente")]
        public Usuarios UsuarioAgente { get; set; }
    }
}
