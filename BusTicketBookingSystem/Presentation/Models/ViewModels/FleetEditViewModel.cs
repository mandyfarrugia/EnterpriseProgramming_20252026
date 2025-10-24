using System.ComponentModel.DataAnnotations;

namespace Presentation.Models.ViewModels
{
    public class FleetEditViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Year Built")]
        public short YearBuilt { get; set; }

        public string? ImagePath { get; set; }

        [Display(Name = "Image")]
        public IFormFile? ImageFile { get; set; }
    }
}