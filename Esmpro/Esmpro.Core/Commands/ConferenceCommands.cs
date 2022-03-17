using Esmpro.Core.Entities;
using ServiceStack;

namespace Esmpro.Core.Commands;

[AutoApply(Behavior.AuditQuery)]
[Route("/conferences", "GET")]
[Route("/conferences/{Id}", "GET")]
[Tag("conferences")]
public class QueryConferenceCommand : QueryDb<Conference>, IReturn<QueryResponse<Conference>>
{
    public long? Id { get; set; }
}

[AutoApply(Behavior.AuditCreate)]
[Route("/conferences", "POST")]
[Tag("conferences")]
public class CreateConferenceCommand : ICreateDb<Conference>, IReturn<IdResponse>
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTimeOffset? StartAt { get; set; }
    public DateTimeOffset? EndAt { get; set; }
    public double Workload { get; set; }
    public bool IsIndoor { get; set; }
    public bool IsInPerson { get; set; }
    public bool IsRemote { get; set; }
    public bool IsRecorded { get; set; }
    public bool IsOffline { get; set; }
}

[AutoApply(Behavior.AuditModify)]
[Route("/conferences/{Id}", "PATCH")]
[Tag("conferences")]
public class UpdateConferenceCommand : IPatchDb<Conference>, IReturn<IdResponse>
{
    public long Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTimeOffset? StartAt { get; set; }
    public DateTimeOffset? EndAt { get; set; }
    public double Workload { get; set; }
    public bool IsIndoor { get; set; }
    public bool IsInPerson { get; set; }
    public bool IsRemote { get; set; }
    public bool IsRecorded { get; set; }
    public bool IsOffline { get; set; }
}

[AutoApply(Behavior.AuditSoftDelete)]
[Route("/conferences/{Id}", "DELETE")]
[Tag("conferences")]
public class DeleteConferenceCommand : IDeleteDb<Conference>, IReturn<IdResponse>
{
    public long Id { get; set; }
}

[AutoFilter(QueryTerm.Ensure, nameof(Conference.DeletedDate), Template = SqlTemplate.IsNotNull)]
[Route("/conferences/deleted")]
[Tag("conferences")]
public class DeletedConferencesCommand : QueryDb<Conference>, IReturn<QueryResponse<Conference>>
{

}