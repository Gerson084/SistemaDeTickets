using Microsoft.EntityFrameworkCore;

namespace SistemaDeTickets.Models
{
    public class ticketContext : DbContext
    {
        public ticketContext(DbContextOptions<ticketContext> options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }

    }
}
