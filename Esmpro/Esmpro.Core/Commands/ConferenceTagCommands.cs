using Esmpro.Core.Entities;
using ServiceStack;

namespace Esmpro.Core.Commands;

[AutoApply(Behavior.AuditQuery)]
[Route("/conferencestags", "GET")]
[Route("/conferencestags/{Id}", "GET")]
[Tag("conferencestags")]
public class QueryConferenceTagCommand : QueryDb<ConferenceTag>, IReturn<QueryResponse<ConferenceTag>>
{
    public long? Id { get; set; }
}

[AutoApply(Behavior.AuditCreate)]
[Route("/conferencestags", "POST")]
[Tag("conferencestags")]
public class CreateConferenceTagCommand : ICreateDb<ConferenceTag>, IReturn<IdResponse>
{
    public long ConferenceId { get; set; }
    public long TagId { get; set; }
}

[AutoApply(Behavior.AuditModify)]
[Route("/conferencestags/{Id}", "PATCH")]
[Tag("conferencestags")]
public class UpdateConferenceTagCommand : IPatchDb<ConferenceTag>, IReturn<IdResponse>
{
    public long Id { get; set; }
    public long ConferenceId { get; set; }
    public long TagId { get; set; }
}

[AutoApply(Behavior.AuditSoftDelete)]
[Route("/conferencestags/{Id}", "DELETE")]
[Tag("conferencestags")]
public class DeleteConferenceTagCommand : IDeleteDb<ConferenceTag>, IReturn<IdResponse>
{
    public long Id { get; set; }
}

[AutoFilter(QueryTerm.Ensure, nameof(ConferenceTag.DeletedDate), Template = SqlTemplate.IsNotNull)]
[Route("/conferencestags/deleted")]
[Tag("conferencestags")]
public class DeletedConferencesTagsCommand : QueryDb<ConferenceTag>, IReturn<QueryResponse<ConferenceTag>>
{

}