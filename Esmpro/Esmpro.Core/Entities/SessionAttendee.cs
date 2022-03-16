namespace Esmpro.Core.Entities
{
    public class SessionAttendee
    {
        public Guid SessionId { get; set; }

        public Session? Session { get; set; }

        public Guid AttendeeId { get; set; }

        public Attendee? Attendee { get; set; }
    }
}
