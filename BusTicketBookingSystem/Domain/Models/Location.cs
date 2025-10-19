using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Location
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}