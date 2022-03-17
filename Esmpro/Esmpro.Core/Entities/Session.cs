using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

[Alias("Sessions")]
public class Session : AuditModel
{
    [Required]
    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(4000)]
    public string? Description { get; set; }

    public DateTimeOffset? StartAt { get; set; }

    public DateTimeOffset? EndAt { get; set; }

    [Computed]
    public TimeSpan Duration =>
        EndAt?.Subtract(StartAt ?? EndAt ?? DateTimeOffset.MinValue) ?? TimeSpan.Zero;

    public long? TrackId { get; set; }
    [Reference]
    public Track? Track { get; set; }

    public long? ConferenceId { get; set; }
    [Reference]
    public Conference? Conference { get; set; }

    //[Reference]
    //public ICollection<SessionSpeaker> SessionSpeakers { get; set; } = default!;

    //[Reference]
    //public ICollection<SessionAttendee> SessionAttendees { get; set; } = default!;


}
