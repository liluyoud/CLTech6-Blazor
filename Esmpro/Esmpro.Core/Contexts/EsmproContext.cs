using Esmpro.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Esmpro.Core.Contexts
{
    public class EsmproContext : DbContext
    {
        public DbSet<Conference> Conferences { get; set; } = default!;
        //public DbSet<Session> Sessions { get; set; } = default!;
        //public DbSet<Track> Tracks { get; set; } = default!;
        //public DbSet<Speaker> Speakers { get; set; } = default!;
        //public DbSet<Attendee> Attendees { get; set; } = default!;


        public EsmproContext(DbContextOptions<EsmproContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("esmpro");

            //builder
            //   .Entity<Attendee>()
            //   .HasIndex(a => a.Identity)
            //   .IsUnique();
        }

    }
}
