using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Bus
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Plate { get; set; }

        [ForeignKey(nameof(FleetFK))]
        public virtual Fleet Fleet { get; set; }
        [Required]
        public Guid FleetFK { get; set; }
    }
}