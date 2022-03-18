using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

[Alias("Speakers")]
public class Speaker : AuditModel
{
    [Required]
    [StringLength(255)]
    public string? Name { get; set; }

    [Index(Unique = true)]
    [Required]
    [StringLength(100)]
    public string? UserName { get; set; }

    [Index(Unique = true)]
    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(100)]
    public string? Phone { get; set; }

    [StringLength(255)]
    public virtual string? WebSite { get; set; }

    [StringLength(4000)]
    public string? Bio { get; set; }

    [Reference]
    public List<SpeakerConference>? SpeakersConferences { get; set; }
    
    [Reference]
    public List<SpeakerSession>? SpeakersSessions { get; set; }

    [Reference]
    public List<SpeakerTrack>? SpeakersTracks { get; set; }
}
