using CLTech.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Esmpro.Core.Entities
{
    public class EventType : EntityModel
    {
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(4000)]
        public string? Description { get; set; }

        public ICollection<Event>? Events { get; set; }

        public EventType(string name)
        {
            Name = name;
        }
        public override string ToString() => $"{Name}";
    }
}
