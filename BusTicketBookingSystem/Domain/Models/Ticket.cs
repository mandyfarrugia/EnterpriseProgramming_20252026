using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string ReferenceNumber { get; set; }

        [Required]
        public DateTime IssueDate { get; set; }

        [ForeignKey(nameof(TicketTypeFK))]
        public virtual TicketType TicketType { get; set; }
        public Guid TicketTypeFK { get; set; }

        [ForeignKey(nameof(LineFK))]
        public virtual Line Line { get; set; }
        public Guid LineFK { get; set; }

        [ForeignKey(nameof(OriginFK))]
        public virtual Location Origin { get; set; }
        [Required]
        public Guid OriginFK { get; set; }

        [ForeignKey(nameof(DestinationFK))]
        public virtual Location Destination { get; set; }
        [Required]
        public Guid DestinationFK { get; set; }

        [ForeignKey(nameof(BusFK))]
        public virtual Bus Bus { get; set; }
        [Required]
        public Guid BusFK { get; set; }
    }
}