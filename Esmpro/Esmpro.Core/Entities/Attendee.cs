using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

[Alias("Attendees")]
public class Attendee : AuditModel
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

    [Reference]
    public List<Register>? RegisteredAt { get; set; }
}
