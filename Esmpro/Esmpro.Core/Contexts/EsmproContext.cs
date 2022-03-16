using Esmpro.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Esmpro.Core.Contexts
{
    public class EsmproContext : DbContext
    {
        public DbSet<Event>? Events { get; set; }
        public DbSet<EventType>? EventTypes { get; set; }

        public static async Task CheckAndSeedDatabaseAsync(EsmproContext context)
        {
            if (await context.Database.EnsureCreatedAsync())
            {
                var eventTypes = EsmproSeed.GetEventTypes();
                if (context.EventTypes != null)
                {
                    context.EventTypes.AddRange(eventTypes);
                    await context.SaveChangesAsync();
                }
            }
        }

        public EsmproContext(DbContextOptions<EsmproContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.HasDefaultSchema("esmpro");
        }
    }
}
