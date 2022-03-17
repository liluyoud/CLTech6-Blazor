using CLTech.Core.Models;
using ServiceStack.DataAnnotations;

namespace Esmpro.Core.Entities;

[Alias("Conferences")]
public class Conference : AuditModel
{
    [Required]
    [StringLength(255)]
    public string? Name { get; set; }

    [StringLength(4000)]
    public string? Description { get; set; }

    public DateTimeOffset? Start { get; set; }

    public DateTimeOffset? End { get; set; }

    public double Workload { get; set; }

    public bool IsIndoor { get; set; }

    public bool IsInPerson { get; set; }

    public bool IsRemote { get; set; }

    public bool IsRecorded { get; set; }

    public bool IsOffline { get; set; }
}
