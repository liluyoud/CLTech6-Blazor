using CLTech.Core.Models;

namespace Esmpro.Core.Entities;

public class ConferenceSpeaker : EntityModel
{
    public long ConferenceId { get; set; }

    public Conference? Conference { get; set; }

    public long SpeakerId { get; set; }

    public Speaker? Speaker { get; set; }
}
