using CLTech.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Esmpro.Core.Entities
{
    public class Track : EntityModel
    {
        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }

        public ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
