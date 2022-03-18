using Esmpro.Core.Entities;
using ServiceStack;

namespace Esmpro.Core.Commands;

[AutoApply(Behavior.AuditQuery)]
[Route("/speakerstracks", "GET")]
[Route("/speakerstracks/{Id}", "GET")]
[Tag("speakerstracks")]
public class QuerySpeakerTrackCommand : QueryDb<SpeakerTrack>, IReturn<QueryResponse<SpeakerTrack>>
{
    public long? Id { get; set; }
}

[AutoApply(Behavior.AuditCreate)]
[Route("/speakerstracks", "POST")]
[Tag("speakerstracks")]
public class CreateSpeakerTrackCommand : ICreateDb<SpeakerTrack>, IReturn<IdResponse>
{
    public long TrackId { get; set; }
    public long SpeakerId { get; set; }
}

[AutoApply(Behavior.AuditModify)]
[Route("/speakerstracks/{Id}", "PATCH")]
[Tag("speakerstracks")]
public class UpdateSpeakerTrackCommand : IPatchDb<SpeakerTrack>, IReturn<IdResponse>
{
    public long Id { get; set; }
    public long TrackId { get; set; }
    public long SpeakerId { get; set; }
}

[AutoApply(Behavior.AuditSoftDelete)]
[Route("/speakerstracks/{Id}", "DELETE")]
[Tag("speakerstracks")]
public class DeleteSpeakerTrackCommand : IDeleteDb<SpeakerTrack>, IReturn<IdResponse>
{
    public long Id { get; set; }
}

[AutoFilter(QueryTerm.Ensure, nameof(SpeakerTrack.DeletedDate), Template = SqlTemplate.IsNotNull)]
[Route("/speakerstracks/deleted")]
[Tag("speakerstracks")]
public class DeletedSpeakersTracksCommand : QueryDb<SpeakerTrack>, IReturn<QueryResponse<SpeakerTrack>>
{

}