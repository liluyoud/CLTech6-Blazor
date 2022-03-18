using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

[Alias("SpeakersSessions")]
public class SpeakerSession : AuditModel
{
    public long SessionId { get; set; }
    [Reference]
    public Session Session { get; set; } = default!;

    public long SpeakerId { get; set; }
    [Reference]
    public Speaker Speaker { get; set; } = default!;
}
