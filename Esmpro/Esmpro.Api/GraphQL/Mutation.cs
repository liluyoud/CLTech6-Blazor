using Esmpro.Core.Contexts;
using Esmpro.Core.Entities;

namespace Esmpro.Api.GraphQL
{
    public record AddConferenceInput (
        string Name,
        string? Description
    );

    public class AddConferencePayload
    {
        public Conference Conference { get; }
        public AddConferencePayload(Conference conference)
        {
            Conference = conference;
        }
    }

    public class Mutation
    {
        public async Task<AddConferencePayload> AddConferenceAsync (
            AddConferenceInput input, [Service] EsmproContext context)
        {
            var conference = new Conference
            {
                Name = input.Name,
                Description = input.Description
            };

            context.Conferences?.Add(conference);
            await context.SaveChangesAsync();

            return new AddConferencePayload(conference);
        }
    }
}
