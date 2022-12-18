using AlunosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunosApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Weslley",
                    Email = "weslleyalberto@gmail.com",
                    Idade = 35
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Gabriel",
                    Email = "gabriel@tim.com.br",
                    Idade = 15
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
