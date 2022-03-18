using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities
{
    [Alias("Registers")]
    public class Register : AuditModel
    {
        public DateTimeOffset RegisterDate { get; set; }

        public RegisterStatus Status { get; set; }

        public long ConferenceId { get; set; }
        [Reference]
        public Conference Conference { get; set; } = default!;

        public long AttendeeId { get; set; }
        [Reference]
        public Attendee Attendee { get; set; } = default!;
    }

    [EnumAsInt]
    public enum RegisterStatus
    {
        Waiting,
        Active,
        Rejected,
        Cancelled
    }
}
