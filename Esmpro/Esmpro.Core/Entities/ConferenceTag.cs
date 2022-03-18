using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

[Alias("ConferencesTags")]
public class ConferenceTag : AuditModel
{
    public long ConferenceId { get; set; }
    [Reference]
    public Conference Conference { get; set; } = default!;

    public long TagId { get; set; }
    [Reference]
    public Tag Tag { get; set; } = default!;

    [Reference]
    public List<ConferenceTag>? ConferencesTags { get; set; }

}
