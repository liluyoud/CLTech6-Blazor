using Esmpro.Core.Entities;
using ServiceStack;

namespace Esmpro.Core.Commands;

[AutoApply(Behavior.AuditQuery)]
[Route("/tags", "GET")]
[Route("/tags/{Id}", "GET")]
[Tag("tags")]
public class QueryTagCommand : QueryDb<Tag>, IReturn<QueryResponse<Tag>>
{
    public long? Id { get; set; }
}

[AutoApply(Behavior.AuditCreate)]
[Route("/tags", "POST")]
[Tag("tags")]
public class CreateTagCommand : ICreateDb<Tag>, IReturn<IdResponse>
{
    public string? Name { get; set; }
}

[AutoApply(Behavior.AuditModify)]
[Route("/tags/{Id}", "PATCH")]
[Tag("tags")]
public class UpdateTagCommand : IPatchDb<Tag>, IReturn<IdResponse>
{
    public long Id { get; set; }
    public string? Name { get; set; } 
}

[AutoApply(Behavior.AuditSoftDelete)]
[Route("/tags/{Id}", "DELETE")]
[Tag("tags")]
public class DeleteTagCommand : IDeleteDb<Tag>, IReturn<IdResponse>
{
    public long Id { get; set; }
}

[AutoFilter(QueryTerm.Ensure, nameof(Tag.DeletedDate), Template = SqlTemplate.IsNotNull)]
[Route("/tags/deleted")]
[Tag("tags")]
public class DeletedTagsCommand : QueryDb<Tag>, IReturn<QueryResponse<Tag>>
{

}