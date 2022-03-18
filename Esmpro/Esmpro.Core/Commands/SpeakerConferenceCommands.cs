using Esmpro.Core.Entities;
using ServiceStack;

namespace Esmpro.Core.Commands;

[AutoApply(Behavior.AuditQuery)]
[Route("/speakersconferences", "GET")]
[Route("/speakersconferences/{Id}", "GET")]
[Tag("speakers")]
public class QuerySpeakerConferenceCommand : QueryDb<SpeakerConference>, IReturn<QueryResponse<SpeakerConference>>
{
    public long? Id { get; set; }
}

[AutoApply(Behavior.AuditCreate)]
[Route("/speakersconferences", "POST")]
[Tag("speakers")]
public class CreateSpeakerConferenceCommand : ICreateDb<SpeakerConference>, IReturn<IdResponse>
{
    public long ConferenceId { get; set; }
    public long SpeakerId { get; set; }
}

[AutoApply(Behavior.AuditModify)]
[Route("/speakersconferences/{Id}", "PATCH")]
[Tag("speakers")]
public class UpdateSpeakerConferenceCommand : IPatchDb<SpeakerConference>, IReturn<IdResponse>
{
    public long Id { get; set; }
    public long ConferenceId { get; set; }
    public long SpeakerId { get; set; }
}

[AutoApply(Behavior.AuditSoftDelete)]
[Route("/speakersconferences/{Id}", "DELETE")]
[Tag("speakers")]
public class DeleteSpeakerConferenceCommand : IDeleteDb<SpeakerConference>, IReturn<IdResponse>
{
    public long Id { get; set; }
}

[AutoFilter(QueryTerm.Ensure, nameof(SpeakerConference.DeletedDate), Template = SqlTemplate.IsNotNull)]
[Route("/speakersconferences/deleted")]
[Tag("speakers")]
public class DeletedSpeakersConferencesCommand : QueryDb<SpeakerConference>, IReturn<QueryResponse<SpeakerConference>>
{

}