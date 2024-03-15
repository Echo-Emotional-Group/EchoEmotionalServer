using Microsoft.EntityFrameworkCore;
using Models;

namespace Contexts
{
    public class DbEchoEmotional : DbContext
    {
        public DbEchoEmotional(DbContextOptions<DbEchoEmotional> configurar) : base(configurar)
        {

        }
        public DbEchoEmotional()
        {

        }

        public DbSet<Emocao> emocoes { get; set; }
        public DbSet<Registro> registros { get; set; }
        public DbSet<Reacao> reacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder b)
        {
            b.Entity<Registro>()
            .HasKey(k => new { k.IdEmocao, k.idReacao });

            b.Entity<Registro>()
           .HasOne(e => e.Reacao)
           .WithMany(p => p.Registros)
           .HasForeignKey(e => e.idReacao);

            b.Entity<Registro>()
            .HasOne(e => e.Emocao)
            .WithMany(p => p.Registros)
            .HasForeignKey(e => e.IdEmocao);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder configurar)
        {
            //configurar.UseInMemoryDatabase("EchoApp");
        }
    }
}