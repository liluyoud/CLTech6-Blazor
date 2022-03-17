using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

public class Session : AuditModel
{
    [Required]
    [StringLength(255)]
    public string? Title { get; set; }

    [StringLength(4000)]
    public string? Abstract { get; set; }

    public DateTimeOffset? StartTime { get; set; }

    public DateTimeOffset? EndTime { get; set; }

    public TimeSpan Duration =>
        EndTime?.Subtract(StartTime ?? EndTime ?? DateTimeOffset.MinValue) ?? TimeSpan.Zero;

    public long? TrackId { get; set; }
    public Track? Track { get; set; }

    public long? ConferenceId { get; set; }
    public Conference? Conference { get; set; }

    [Reference]
    public ICollection<SessionSpeaker> SessionSpeakers { get; set; } = default!;

    [Reference]
    public ICollection<SessionAttendee> SessionAttendees { get; set; } = default!;


}
