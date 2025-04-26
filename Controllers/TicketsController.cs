using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaDeTickets.Models;

namespace SistemaDeTickets.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ticketContext _context;

        // GET: Tickets/Asignar/5
        public async Task<IActionResult> Asignar(int? id)
        {
            if (id == null)
                return NotFound();

            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null || ticket.id_usuario_agente != null)
                return NotFound();

            // Lista de agentes disponibles
            ViewData["Agentes"] = _context.Usuarios
                .Where(u => u.rol == "agente")
                .Select(u => new SelectListItem
                {
                    Value = u.id_usuario.ToString(),
                    Text = u.nombre + " " + u.apellido
                }).ToList();

            return View(ticket);
        }

        // POST: Tickets/Asignar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Asignar(int id, int idAgente)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
                return NotFound();

            ticket.id_usuario_agente = idAgente;
            ticket.estado = "En proceso";
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
