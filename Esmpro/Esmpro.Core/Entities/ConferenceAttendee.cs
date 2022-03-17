using CLTech.Core.Models;

namespace Esmpro.Core.Entities
{
    public class ConferenceAttendee : EntityModel
    {
        public long ConferenceId { get; set; }

        public Conference? Session { get; set; }

        public long AttendeeId { get; set; }

        public Attendee? Attendee { get; set; }
    }
}
