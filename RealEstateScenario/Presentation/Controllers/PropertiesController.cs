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
                Locality = "L-Imgarr",
                PropertyType = "Apartment",
                ReferenceNumber = "ST130825",
                ContractType = "To Let",
                FloorArea = 85.5m,
                Price = 125000m,
                Beds = 3,
                Description = "A beautiful apartment in a rural village in the Northern Region.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/d/d6/Zebbieh%2C_Mgarr%2C_Malta_-_panoramio_%2828%29.jpg"
            },
            new Property()
            {
                Id = 2,
                Locality = "Il-Mosta",
                PropertyType = "House of Character",
                ReferenceNumber = "ST479343",
                ContractType = "For Sale",
                FloorArea = 84.0m,
                Price = 1000000m,
                Beds = 2,
                Description = "A semi converted 3 bedroom Townhouse with Garden and Garage in Mosta. The property is made up of an open plan Kitchen, Living and Dining area at ground floor level, leading out onto a spacious outdoor area with space for a pool. At first floor level, there are 2 double Bedrooms both having en-suite facilities. At roof level another room which can be used either as a washroom or bedroom, with a bathroom and rooftop jacuzzi complete the property which also comes with a 1 car garage.",
                Image = "https://scontent.fmla3-1.fna.fbcdn.net/v/t39.30808-6/474561197_611332318310163_1772044688912995423_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=cc71e4&_nc_ohc=gvF-Iijfz6wQ7kNvwGOVLER&_nc_oc=AdmWzWP66BG7la1h0qmCP3Tdynpr5GkAE5BmOXQFRnIreTiHOn9XLLB7aN3FhFNDhHA&_nc_zt=23&_nc_ht=scontent.fmla3-1.fna&_nc_gid=DZ8bMhjH8yu5stLJAvALNQ&oh=00_Afcu1j-x6XydhtkxO_6KAeqMkUOMz4ApQtcBtVc27sw6Sg&oe=68E70104"
            }
        };

        public IActionResult Index()
        {
            return View(properties);
        }
    }
}
