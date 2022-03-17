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

    public static void FillAuditWithDefault(this IEnumerable<AuditBase> audits)
    {
        foreach (var audit in audits)
        {
            audit.FillAuditWithDefault();
        }
    }
}
