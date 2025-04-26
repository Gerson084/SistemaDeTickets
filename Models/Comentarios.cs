using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaDeTickets.Models
{
    public class Comentarios
    {
        [Key]
        public int id_comentario { get; set; }

        [Required]
        public int id_ticket { get; set; }

        [Required]
        public int id_usuario { get; set; }

        [Required]
        public string contenido { get; set; }

        [Required]
        public DateTime fecha_comentario { get; set; }

        // Relaciones
        [ForeignKey("id_ticket")]
        public Tickets Ticket { get; set; }

        [ForeignKey("id_usuario")]
        public Usuarios Usuario { get; set; }
    }
}
