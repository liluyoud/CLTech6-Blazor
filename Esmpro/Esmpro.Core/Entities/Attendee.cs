using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities
{
    public class Attendee : EntityModel
    {
        [Required]
        [StringLength(255)]
        public string? Name { get; set; }

        [Index(Unique = true)]
        [Required]
        [StringLength(100)]
        public string? Identity { get; set; }

        [Index(Unique = true)]
        [StringLength(100)]
        public string? Email { get; set; }

        [StringLength(100)]
        public string? Phone { get; set; }

        [StringLength(255)]
        public string? EmailAddress { get; set; }

        [Reference]
        public ICollection<ConferenceAttendee> ConferencesAttendees { get; set; } = default!;

        [Reference]
        public ICollection<SessionAttendee> SessionsAttendees { get; set; } = default!;
    }
}
