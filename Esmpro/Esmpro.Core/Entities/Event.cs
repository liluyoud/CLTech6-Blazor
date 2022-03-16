using CLTech.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Esmpro.Core.Entities
{
    public class Event : EntityModel
    {
        [MaxLength(255)]
        public string Name { get; set; }

        public string? Description { get; set; }

        public double Workload { get; set; }

        public bool Indoor { get; set; }

        public ModalityType Modality { get; set; }

        public long? EventTypeId { get; set; }
        public EventType? EventType { get; set; }

        public Event(string name)
        {
            Name = name;
        }

        public override string ToString() => $"{Name}: {Workload}h";
    }

    public enum ModalityType
    {
        InPerson,
        Remote,
        InPersonAndRemote
    }
}
