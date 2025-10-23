using System.ComponentModel.DataAnnotations;

namespace Presentation.Models.ViewModels
{
    public class FleetEditViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public short YearBuilt { get; set; }

        public string? ImagePath { get; set; }

        public IFormFile? ImageFile { get; set; }
    }
}