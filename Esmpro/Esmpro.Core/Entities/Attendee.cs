using CLTech.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Esmpro.Core.Entities
{
    public class Attendee : EntityModel
    {
        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Identity { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(100)]
        public string? Phone { get; set; }

        [MaxLength(255)]
        public string? EmailAddress { get; set; }

        public ICollection<SessionAttendee> SessionsAttendees { get; set; } = new List<SessionAttendee>();
    }
}
