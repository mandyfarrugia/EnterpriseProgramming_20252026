using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class PropertiesController : Controller
    {
        private static List<Property> properties = new List<Property>() 
        {
            new Property()
            {
                Id = 1,
                Locality = "Gudja",
                PropertyType = "Apartment",
                ReferenceNumber = "ST130825",
                ContractType = "To Let",
                FloorArea = 85.5m,
                Price = 125000m,
                Beds = 3,
                Description = "A beautiful apartment in the village in the South Eastern Region.",
                Image = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/633557974.jpg?k=5cb63cdd2da5c77805bb6eb1a2aa82a30fb5fcb1b8e78e0e0a16e1f28d915582&o=&hp=1"
            },
            new Property()
            {
                Id = 2,
                Locality = "Mosta",
                PropertyType = "House of Character",
                ReferenceNumber = "ST479343",
                ContractType = "For Sale",
                FloorArea = 84.0m,
                Price = 1000000m,
                Beds = 2,
                Description = "A semi converted 3 bedroom Townhouse with Garden and Garage in Mosta. The property is made up of an open plan Kitchen, Living and Dining area at ground floor level, leading out onto a spacious outdoor area with space for a pool. At first floor level, there are 2 double Bedrooms both having en-suite facilities. At roof level another room which can be used either as a washroom or bedroom, with a bathroom and rooftop jacuzzi complete the property which also comes with a 1 car garage.",
                Image = "https://www.propertymarket.com.mt/wp-content/plugins/property-market/files/SGM/listings/sgmst479343_cc6477e3-b076-4935-9e66-4ebbbb58a1a4.jpg"
            }
        };

        public IActionResult Index()
        {
            return View(properties);
        }
    }
}
