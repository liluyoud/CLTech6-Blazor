using CLTech.Core.Interfaces;
using ServiceStack.DataAnnotations;

namespace CLTech.Core.Models;

public class EntityModel : IEntityModel
{
    [AutoIncrement]
    public long Id { get; set; }
}

