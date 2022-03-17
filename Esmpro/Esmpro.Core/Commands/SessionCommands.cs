using Esmpro.Core.Entities;
using ServiceStack;

namespace Esmpro.Core.Commands;

[AutoApply(Behavior.AuditQuery)]
[Route("/sessions", "GET")]
[Route("/sessions/{Id}", "GET")]
[Tag("sessions")]
public class QuerySessionCommand : QueryDb<Session>, IReturn<QueryResponse<Session>>
{
    public long? Id { get; set; }
}

[AutoApply(Behavior.AuditCreate)]
[Route("/sessions", "POST")]
[Tag("sessions")]
public class CreateSessionCommand : ICreateDb<Session>, IReturn<IdResponse>
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTimeOffset? StartAt { get; set; }
    public DateTimeOffset? Endat { get; set; }
    public long ConferenceId { get; set; }
    public long TrackId { get; set; }
}

[AutoApply(Behavior.AuditModify)]
[Route("/sessions/{Id}", "PATCH")]
[Tag("sessions")]
public class UpdateSessionCommand : IPatchDb<Session>, IReturn<IdResponse>
{
    public long Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTimeOffset? StartAt { get; set; }
    public DateTimeOffset? EndAt { get; set; }
    public long ConferenceId { get; set; }
    public long TrackId { get; set; }
}

[AutoApply(Behavior.AuditSoftDelete)]
[Route("/sessions/{Id}", "DELETE")]
[Tag("sessions")]
public class DeleteSessionCommand : IDeleteDb<Session>, IReturn<IdResponse>
{
    public long Id { get; set; }
}

[AutoFilter(QueryTerm.Ensure, nameof(Session.DeletedDate), Template = SqlTemplate.IsNotNull)]
[Route("/sessions/deleted")]
[Tag("sessions")]
public class DeletedSessionsCommand : QueryDb<Session>, IReturn<QueryResponse<Session>>
{

}