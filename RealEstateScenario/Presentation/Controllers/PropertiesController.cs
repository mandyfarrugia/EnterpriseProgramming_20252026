using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class PropertiesController : Controller
    {
        public IActionResult Index()
        {
            Property property = new Property() 
            {
                Id = 1,
                Locality = "Gudja",
                PropertyType = "Apartment",
                ReferenceNumber = "REF-130825",
                ContractType = "To Let",
                FloorArea = 85.5m,
                Price = 125000m,
                Beds = 3,
                Description = "A beautiful apartment in the village in the South Eastern Region.",
                Image = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/633557974.jpg?k=5cb63cdd2da5c77805bb6eb1a2aa82a30fb5fcb1b8e78e0e0a16e1f28d915582&o=&hp=1"
            };

            return View(property);
        }
    }
}
