using CLTech.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Esmpro.Core.Entities
{
    public class Conference : EntityModel
    {
        [MaxLength(255)]
        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public DateTimeOffset? Start { get; set; }

        public DateTimeOffset? End { get; set; }

        public double Workload { get; set; }

        public bool IsIndoor { get; set; }

        public bool IsInPerson { get; set; }

        public bool IsRemote { get; set; }

        public bool IsRecorded { get; set; }

        public bool IsOffline { get; set; }

        public override string ToString() => $"{Name}: {Workload}h";
    }
}
