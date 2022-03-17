using ServiceStack;

namespace CLTech.Core.Extensions;

public static class OrmLiteExtensions
{
    public static void FillAuditWithDefault(this AuditBase audit)
    {
        audit.CreatedBy = "system";
        audit.ModifiedBy = "system";
        audit.CreatedDate = DateTime.UtcNow;
        audit.ModifiedDate = DateTime.UtcNow;
    }
}
