using Esmpro.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Esmpro.Core.Contexts
{
    public class EsmproContext : DbContext
    {
        public DbSet<Conference> Conferences { get; set; } = default!;
        public DbSet<Session> Sessions { get; set; } = default!;
        public DbSet<Track> Tracks { get; set; } = default!;
        public DbSet<Speaker> Speakers { get; set; } = default!;
        public DbSet<Attendee> Attendees { get; set; } = default!;


        public EsmproContext(DbContextOptions<EsmproContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("esmpro");

            builder
               .Entity<Attendee>()
               .HasIndex(a => a.Identity)
               .IsUnique();

            // Many-to-many: Session <-> Attendee
            builder
                .Entity<SessionAttendee>()
                .HasKey(sa => new { sa.SessionId, sa.AttendeeId });

            // Many-to-many: Speaker <-> Session
            builder
                .Entity<SessionSpeaker>()
                .HasKey(ss => new { ss.SessionId, ss.SpeakerId });
        }

        //public static async Task CheckAndSeedDatabaseAsync(EsmproContext context)
        //{
        //    //if (await context.Database.EnsureCreatedAsync())
        //    //{
        //    //    var eventTypes = EsmproSeed.GetEventTypes();
        //    //    if (context.EventTypes != null)
        //    //    {
        //    //        context.EventTypes.AddRange(eventTypes);
        //    //        await context.SaveChangesAsync();
        //    //    }
        //    //}
        //}

    }
}
