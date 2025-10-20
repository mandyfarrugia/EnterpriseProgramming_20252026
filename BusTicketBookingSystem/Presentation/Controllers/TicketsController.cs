using DataAccess.Repositories;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models.ViewModels;

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

        [HttpGet]
        public IActionResult Create([FromServices] TicketTypesRepository ticketTypesRepository, 
                                    [FromServices] LinesRepository linesRepository, 
                                    [FromServices] LocationsRepository locationsRepository,
                                    [FromServices] BusesRepository busesRepository)
        {
            TicketCreateViewModel ticketCreateViewModel = new TicketCreateViewModel();
            ticketCreateViewModel.TicketTypes = ticketTypesRepository.Get().ToList();
            ticketCreateViewModel.Lines = linesRepository.Get().ToList();
            ticketCreateViewModel.Origins = locationsRepository.Get().ToList();
            ticketCreateViewModel.Destinations = locationsRepository.Get().ToList();
            ticketCreateViewModel.Buses = busesRepository.Get().ToList();
            return View(ticketCreateViewModel);
        }

        [HttpPost]
        public IActionResult Create(TicketCreateViewModel ticketCreateViewModel)
        {
            return View();
        }
    
        public IActionResult Delete(Guid id)
        {
            this._ticketsRepository.DeleteTicket(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
