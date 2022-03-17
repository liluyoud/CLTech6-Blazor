using CLTech.Core.Interfaces;
using ServiceStack;
using ServiceStack.DataAnnotations;

namespace CLTech.Core.Models;

public class AuditModel : AuditBase, IEntityModel, IAuditModel
{
    [AutoIncrement]
    public long Id { get; set; }
}


