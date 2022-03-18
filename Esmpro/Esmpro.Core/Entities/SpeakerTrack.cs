using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

[Alias("SpeakersTracks")]
public class SpeakerTrack : AuditModel
{
    public long TrackId { get; set; }
    [Reference]
    public Track Track { get; set; } = default!;

    public long SpeakerId { get; set; }
    [Reference]
    public Speaker Speaker { get; set; } = default!;
}
