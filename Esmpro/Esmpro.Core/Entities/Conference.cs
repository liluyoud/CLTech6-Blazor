using CLTech.Core.Models;
using ServiceStack;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

[Alias("Conferences")]
public class Conference : AuditModel
{
    [Required]
    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(4000)]
    public string? Description { get; set; }

    public DateTimeOffset? StartAt { get; set; }

    public DateTimeOffset? EndAt { get; set; }

    public double? Workload { get; set; }

    public bool? IsIndoor { get; set; }

    public bool? IsInPerson { get; set; }

    public bool? IsRemote { get; set; }

    public bool? IsRecorded { get; set; }

    public bool? IsOffline { get; set; }

    [Reference]
    public List<Track>? Tracks { get; set; }

    [Reference]
    public List<Session>? Sessions { get; set; }

    [Reference]
    public List<Register>? Registereds { get; set; }

    [Reference]
    public List<SpeakerConference>? SpeakersConferences { get; set; }
}
