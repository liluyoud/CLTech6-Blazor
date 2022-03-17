using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

public class Conference : AuditModel
{
    [Required]
    [StringLength(255)]
    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTimeOffset? Start { get; set; }

    public DateTimeOffset? End { get; set; }

    public double Workload { get; set; }

    public bool IsIndoor { get; set; }

    public bool IsInPerson { get; set; }

    public bool IsRemote { get; set; }

    public bool IsRecorded { get; set; }

    public bool IsOffline { get; set; }

    [Reference]
    public ICollection<Track> Tracks { get; set; } = default!;

    [Reference]
    public ICollection<Session> Sessions { get; set; } = default!;

    public ICollection<ConferenceAttendee> ConferenceAttendees { get; set; } = default!;

    public ICollection<ConferenceSpeaker> ConferenceSpeakers { get; set; } = default!;
}
