using Microsoft.EntityFrameworkCore;
using Models;

namespace Contexts {

// Banco de dados 
public class DbEchoEmotional : DbContext 
{
    public DbEchoEmotional(DbContextOptions<DbEchoEmotional> options) : base(options)
    {
    }

        // Entidades
        public DbSet<Perfil_User> perfil_users { get; set; }
        public DbSet<Emotion> emotions { get; set; }

        public DbSet<Emotion_Reaction> emotion_Reactions {get; set;}

        public DbSet<Reaction> reactions {get; set;}

        protected override void OnModelCreating(ModelBuilder b)
        {
            b.Entity<Emotion> ()
             .HasOne(e => e.Perfil_User)
             .WithMany(p => p.Emotions)
             .HasForeignKey(e => e.Id_Post);

             b.Entity<Perfil_User>()
              .Property(c => c.Id_account_facebook)
              .IsRequired();


            // Chaves estrangeiras da tabela de junção
              b.Entity<Emotion_Reaction>()
              .HasKey(k => new { k.Emotion_Id, k.Reaction_Id, k.Id_account_facebook });

              b.Entity<Emotion_Reaction> ()
             .HasOne(e => e.Reaction)
             .WithMany(p => p.Emotion_Reactions)
             .HasForeignKey(e => e.Reaction_Id);

             b.Entity<Emotion_Reaction> ()
             .HasOne(e => e.Emotion)
             .WithMany(p => p.Emotion_Reactions)
             .HasForeignKey(e => e.Emotion_Id);

              b.Entity<Emotion_Reaction> ()
             .HasOne(e => e.Perfil_User)
             .WithMany(p => p.Emotion_Reactions)
             .HasForeignKey(e => e.Id_account_facebook);

        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder configurar)
        {
            //configurar.UseInMemoryDatabase("EchoApp");
        }
        
            
    }


}