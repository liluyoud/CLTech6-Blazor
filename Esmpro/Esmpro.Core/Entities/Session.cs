using CLTech.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Esmpro.Core.Entities
{
    public class Session : EntityModel
    {
        [Required]
        [MaxLength(255)]
        public string? Title { get; set; }

        [MaxLength(4000)]
        public string? Abstract { get; set; }

        public DateTimeOffset? StartTime { get; set; }

        public DateTimeOffset? EndTime { get; set; }

        public TimeSpan Duration =>
            EndTime?.Subtract(StartTime ?? EndTime ?? DateTimeOffset.MinValue) ?? TimeSpan.Zero;

        public int? TrackId { get; set; }
        public Track? Track { get; set; }

        public ICollection<SessionSpeaker> SessionSpeakers { get; set; } =
            new List<SessionSpeaker>();

        public ICollection<SessionAttendee> SessionAttendees { get; set; } =
            new List<SessionAttendee>();


    }
}
