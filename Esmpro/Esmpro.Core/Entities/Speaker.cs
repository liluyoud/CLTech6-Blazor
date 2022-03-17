using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

public class Speaker : AuditModel
{
    [Required]
    [StringLength(255)]
    public string? Name { get; set; }
    
    [Required]
    [StringLength(100)]
    public string? Identity { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(100)]
    public string? Phone { get; set; }

    [StringLength(255)]
    public virtual string? WebSite { get; set; }

    [StringLength(4000)]
    public string? Bio { get; set; }

    public ICollection<SessionSpeaker> SessionSpeakers { get; set; } =  default!;
}
