using Esmpro.Core.Entities;
using ServiceStack;

namespace Esmpro.Core.Commands;

[AutoApply(Behavior.AuditQuery)]
[Route("/registers", "GET")]
[Route("/registers/{Id}", "GET")]
[Tag("registers")]
public class QueryEnrollmentCommand : QueryDb<Register>, IReturn<QueryResponse<Register>>
{
    public long? Id { get; set; }
}

[AutoApply(Behavior.AuditCreate)]
[Route("/registers", "POST")]
[Tag("registers")]
public class CreateEnrollmentCommand : ICreateDb<Register>, IReturn<IdResponse>
{
    public DateTimeOffset EnrollAt { get; set; } = DateTimeOffset.UtcNow;
    public RegisterStatus Status { get; set; }
    public long ConferenceId { get; set; }
    public long AttendeeId { get; set; }
}

[AutoApply(Behavior.AuditModify)]
[Route("/registers/{Id}", "PATCH")]
[Tag("registers")]
public class UpdateEnrollmentCommand : IPatchDb<Register>, IReturn<IdResponse>
{
    public long Id { get; set; }
    public DateTimeOffset EnrollAt { get; set; } = DateTimeOffset.UtcNow;
    public RegisterStatus Status { get; set; }
    public long ConferenceId { get; set; }
    public long AttendeeId { get; set; }
}

[AutoApply(Behavior.AuditSoftDelete)]
[Route("/registers/{Id}", "DELETE")]
[Tag("registers")]
public class DeleteEnrollmentCommand : IDeleteDb<Register>, IReturn<IdResponse>
{
    public long Id { get; set; }
}

[AutoFilter(QueryTerm.Ensure, nameof(Register.DeletedDate), Template = SqlTemplate.IsNotNull)]
[Route("/registers/deleted")]
[Tag("registers")]
public class DeletedEnrollmentCommand : QueryDb<Register>, IReturn<QueryResponse<Attendee>>
{

}