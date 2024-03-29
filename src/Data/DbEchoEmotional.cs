using Microsoft.EntityFrameworkCore;
using Models;

namespace Contexts
{
    public class DbEchoEmotional : DbContext
    {
        public DbEchoEmotional(DbContextOptions<DbEchoEmotional> options) : base(options)
        {

        }

        public DbSet<Emotion> Emotions { get; set; }
        public DbSet<Reaction> Reactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emotion>()
                .HasKey(e => e.PostId);

            modelBuilder.Entity<Emotion>()
                .Property(e => e.LastEdition)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Reaction>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Reaction>()
                .HasOne<Emotion>(r => r.Emotion)
                .WithMany(e => e.Reactions)
                .HasForeignKey(r => r.PostId);
        }
    }
}