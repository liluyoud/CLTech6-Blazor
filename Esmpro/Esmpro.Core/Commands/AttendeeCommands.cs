using Esmpro.Core.Entities;
using ServiceStack;

namespace Esmpro.Core.Commands;

[AutoApply(Behavior.AuditQuery)]
[Route("/attendees", "GET")]
[Route("/attendees/{Id}", "GET")]
[Tag("attendees")]
public class QueryAttendeeCommand : QueryDb<Attendee>, IReturn<QueryResponse<Attendee>>
{
    public long? Id { get; set; }
}

[AutoApply(Behavior.AuditCreate)]
[Route("/attendees", "POST")]
[Tag("attendees")]
public class CreateAttendeeCommand : ICreateDb<Attendee>, IReturn<IdResponse>
{
    public string Name { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string? Phone { get; set; }
}

[AutoApply(Behavior.AuditModify)]
[Route("/attendees/{Id}", "PATCH")]
[Tag("attendees")]
public class UpdateAttendeeCommand : IPatchDb<Attendee>, IReturn<IdResponse>
{
    public long Id { get; set; }
    public string Name { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string? Phone { get; set; }
}

[AutoApply(Behavior.AuditSoftDelete)]
[Route("/attendees/{Id}", "DELETE")]
[Tag("attendees")]
public class DeleteAttendeeCommand : IDeleteDb<Attendee>, IReturn<IdResponse>
{
    public long Id { get; set; }
}

[AutoFilter(QueryTerm.Ensure, nameof(Attendee.DeletedDate), Template = SqlTemplate.IsNotNull)]
[Route("/attendees/deleted")]
[Tag("attendees")]
public class DeletedAttendeesCommand : QueryDb<Attendee>, IReturn<QueryResponse<Attendee>>
{

}