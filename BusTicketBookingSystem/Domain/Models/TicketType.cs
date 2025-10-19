using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class TicketType
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Cost { get; set; }
    }
}