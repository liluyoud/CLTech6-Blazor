using CLTech.Core.Models;
using ServiceStack;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

[Alias("Tracks")]
public class Track : AuditModel
{
    [Required]
    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(4000)]
    public string? Description { get; set; }

    public DateTimeOffset? StartAt { get; set; }

    public DateTimeOffset? EndAt { get; set; }

    public long? ConferenceId { get; set; }
    [Reference]
    public Conference? Conference { get; set; }

    public long? SessionId { get; set; }
    [Reference]
    public List<Session>? Sessions { get; set; }

    [Reference]
    public List<SpeakerTrack>? SpeakersTracks { get; set; }

}
