using CLTech.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Esmpro.Core.Entities
{
    public class Speaker : EntityModel
    {
        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string? Identity { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(100)]
        public string? Phone { get; set; }

        [MaxLength(255)]
        public virtual string? WebSite { get; set; }

        [MaxLength(4000)]
        public string? Bio { get; set; }

        public ICollection<SessionSpeaker> SessionSpeakers { get; set; } =  new List<SessionSpeaker>();

        public override string ToString() => $"{Name}: {Email}";
    }
}
