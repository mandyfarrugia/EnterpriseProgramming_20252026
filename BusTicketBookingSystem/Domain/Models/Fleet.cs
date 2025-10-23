using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Fleet
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public short YearBuilt { get; set; }

        public string? ImagePath { get; set; }
    }
}