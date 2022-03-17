using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

public class Track : AuditModel
{
    [Required]
    [StringLength(255)]
    public string? Name { get; set; }

    public long? ConferenceId { get; set; }
    public Conference? Conference { get; set; }

    public ICollection<Session> Sessions { get; set; } = default!;
}
