using CLTech.Core.Models;
using ServiceStack;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

[Alias("Tags")]
public class Tag : AuditModel
{
    [Required]
    [StringLength(100)]
    public string? Name { get; set; }

    [Reference]
    public List<ConferenceTag>? ConferencesTags { get; set; }

}
