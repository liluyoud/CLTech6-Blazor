using Esmpro.Core.Entities;
using ServiceStack;

namespace Esmpro.Core.Commands;

[AutoApply(Behavior.AuditQuery)]
[Route("/tracks", "GET")]
[Route("/tracks/{Id}", "GET")]
[Tag("tracks")]
public class QueryTrackCommand : QueryDb<Track>, IReturn<QueryResponse<Track>>
{
    public long? Id { get; set; }
}

[AutoApply(Behavior.AuditCreate)]
[Route("/tracks", "POST")]
[Tag("tracks")]
public class CreateTrackCommand : ICreateDb<Track>, IReturn<IdResponse>
{
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTimeOffset? StartAt { get; set; }
    public DateTimeOffset? Endat { get; set; }
    public long ConferenceId { get; set; }
}

[AutoApply(Behavior.AuditModify)]
[Route("/tracks/{Id}", "PATCH")]
[Tag("tracks")]
public class UpdateTrackCommand : IPatchDb<Track>, IReturn<IdResponse>
{
    public long Id { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public DateTimeOffset? StartAt { get; set; }
    public DateTimeOffset? EndAt { get; set; }
    public long ConferenceId { get; set; }
}

[AutoApply(Behavior.AuditSoftDelete)]
[Route("/tracks/{Id}", "DELETE")]
[Tag("tracks")]
public class DeleteTrackCommand : IDeleteDb<Track>, IReturn<IdResponse>
{
    public long Id { get; set; }
}

[AutoFilter(QueryTerm.Ensure, nameof(Track.DeletedDate), Template = SqlTemplate.IsNotNull)]
[Route("/tracks/deleted")]
[Tag("tracks")]
public class DeletedTracksCommand : QueryDb<Track>, IReturn<QueryResponse<Track>>
{

}