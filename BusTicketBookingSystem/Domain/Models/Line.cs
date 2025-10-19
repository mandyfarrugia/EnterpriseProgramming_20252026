using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Line
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
