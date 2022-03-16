using Esmpro.Core.Contexts;
using Esmpro.Core.Entities;

namespace Esmpro.Api.GraphQL
{
    public class Query
    {
        [UseProjection]
        [UseSorting]
        [UseFiltering]
        public IQueryable<Conference>? GetEventTypes([Service] EsmproContext context)
            => context.Conferences;
        
            
    }
}
