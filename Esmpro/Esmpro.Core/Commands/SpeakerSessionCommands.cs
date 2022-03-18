using Esmpro.Core.Entities;
using ServiceStack;

namespace Esmpro.Core.Commands;

[AutoApply(Behavior.AuditQuery)]
[Route("/speakerssessions", "GET")]
[Route("/speakerssessions/{Id}", "GET")]
[Tag("speakerssessions")]
public class QuerySpeakerSessionCommand : QueryDb<SpeakerSession>, IReturn<QueryResponse<SpeakerSession>>
{
    public long? Id { get; set; }
}

[AutoApply(Behavior.AuditCreate)]
[Route("/speakerssessions", "POST")]
[Tag("speakerssessions")]
public class CreateSpeakerSessionCommand : ICreateDb<SpeakerSession>, IReturn<IdResponse>
{
    public long SessionId { get; set; }
    public long SpeakerId { get; set; }
}

[AutoApply(Behavior.AuditModify)]
[Route("/speakerssessions/{Id}", "PATCH")]
[Tag("speakerssessions")]
public class UpdateSpeakerSessionCommand : IPatchDb<SpeakerSession>, IReturn<IdResponse>
{
    public long Id { get; set; }
    public long SessionId { get; set; }
    public long SpeakerId { get; set; }
}

[AutoApply(Behavior.AuditSoftDelete)]
[Route("/speakerssessions/{Id}", "DELETE")]
[Tag("speakerssessions")]
public class DeleteSpeakerSessionCommand : IDeleteDb<SpeakerSession>, IReturn<IdResponse>
{
    public long Id { get; set; }
}

[AutoFilter(QueryTerm.Ensure, nameof(SpeakerSession.DeletedDate), Template = SqlTemplate.IsNotNull)]
[Route("/speakerssessions/deleted")]
[Tag("speakerssessions")]
public class DeletedSpeakersSessionsCommand : QueryDb<SpeakerSession>, IReturn<QueryResponse<SpeakerSession>>
{

}