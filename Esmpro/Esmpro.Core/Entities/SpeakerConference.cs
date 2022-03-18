using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

[Alias("SpeakersConferences")]
public class SpeakerConference : AuditModel
{
    public long ConferenceId { get; set; }
    [Reference]
    public Conference Conference { get; set; } = default!;

    public long SpeakerId { get; set; }
    [Reference]
    public Speaker Speaker { get; set; } = default!;
}
