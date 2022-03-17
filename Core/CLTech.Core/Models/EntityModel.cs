using ServiceStack.DataAnnotations;

namespace CLTech.Core.Models;

public class EntityModel : IEntityModel
{
    [AutoIncrement]
    public long Id { get; set; }
}

public interface IEntityModel
{
    long Id { get; set; }
}