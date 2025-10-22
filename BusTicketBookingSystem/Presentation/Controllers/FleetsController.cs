using DataAccess.Repositories;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models.ViewModels;

namespace Presentation.Controllers
{
    public class FleetsController : Controller
    {
        private FleetsRepository _fleetsRepository;

        public FleetsController(FleetsRepository fleetsRepository)
        {
            this._fleetsRepository = fleetsRepository;
        }

        public IActionResult Index()
        {
            List<Fleet> fleets = this._fleetsRepository.Get().ToList();
            return View(fleets);
        }

        [HttpGet]
        public IActionResult Create()
        {
            FleetCreateViewModel fleetCreateViewModel = new FleetCreateViewModel();
            return View(fleetCreateViewModel);
        }
    }
}
