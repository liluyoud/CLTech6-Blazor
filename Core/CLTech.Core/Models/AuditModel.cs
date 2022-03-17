using ServiceStack;
using ServiceStack.DataAnnotations;

namespace CLTech.Core.Models;

public class AuditModel : AuditBase, IEntityModel
{
    [AutoIncrement]
    public long Id { get; set; }
}


