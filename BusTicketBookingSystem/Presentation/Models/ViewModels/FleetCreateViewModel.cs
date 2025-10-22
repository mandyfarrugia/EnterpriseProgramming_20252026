using System.ComponentModel.DataAnnotations;

namespace Presentation.Models.ViewModels
{
    public class FleetCreateViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public short YearBuilt { get; set; }

        public IFormFile? ImagePath { get; set; }
    }
}
