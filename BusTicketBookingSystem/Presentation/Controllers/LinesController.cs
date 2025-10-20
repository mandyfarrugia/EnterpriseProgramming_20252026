using DataAccess.Repositories;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class LinesController : Controller
    {
        private LinesRepository _linesRepository;

        public LinesController(LinesRepository linesRepository)
        {
            this._linesRepository = linesRepository;
        }

        public IActionResult Index()
        {
            List<Line> lines = this._linesRepository.Get().OrderBy(line => line.Name).ToList();
            return View(lines);
        }
    }
}
