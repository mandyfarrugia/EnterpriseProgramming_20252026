using DataAccess.Repositories;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class TicketsController : Controller
    {
        private TicketsRepository _ticketsRepository;

        public TicketsController(TicketsRepository ticketsRepository)
        {
            this._ticketsRepository = ticketsRepository;
        }

        public IActionResult Index()
        {
            List<Ticket> tickets = this._ticketsRepository.Get().ToList();
            return View(tickets);
        }

        public IActionResult Create()
        {
            Ticket ticket = new Ticket();
            return View(ticket);
        }
    
        public IActionResult Delete(Guid id)
        {
            this._ticketsRepository.DeleteTicket(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
