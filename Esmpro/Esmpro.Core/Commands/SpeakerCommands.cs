using Esmpro.Core.Entities;
using ServiceStack;

namespace Esmpro.Core.Commands;

[AutoApply(Behavior.AuditQuery)]
[Route("/speakers", "GET")]
[Route("/speakers/{Id}", "GET")]
[Tag("speakers")]
public class QuerySpeakerCommand : QueryDb<Speaker>, IReturn<QueryResponse<Speaker>>
{
    public long? Id { get; set; }
}

[AutoApply(Behavior.AuditCreate)]
[Route("/speakers", "POST")]
[Tag("speakers")]
public class CreateSpeakerCommand : ICreateDb<Speaker>, IReturn<IdResponse>
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTimeOffset? StartAt { get; set; }
    public DateTimeOffset? Endat { get; set; }
    public long ConferenceId { get; set; }
    public long TrackId { get; set; }
}

[AutoApply(Behavior.AuditModify)]
[Route("/speakers/{Id}", "PATCH")]
[Tag("speakers")]
public class UpdateSpeakerCommand : IPatchDb<Speaker>, IReturn<IdResponse>
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
[Route("/speakers/{Id}", "DELETE")]
[Tag("speakers")]
public class DeleteSpeakerCommand : IDeleteDb<Speaker>, IReturn<IdResponse>
{
    public long Id { get; set; }
}

[AutoFilter(QueryTerm.Ensure, nameof(Speaker.DeletedDate), Template = SqlTemplate.IsNotNull)]
[Route("/speakers/deleted")]
[Tag("speakers")]
public class DeletedSpeakersCommand : QueryDb<Speaker>, IReturn<QueryResponse<Speaker>>
{

}