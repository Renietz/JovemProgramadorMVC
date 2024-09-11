using JovemProgramadorMVC.data.Mapeamento;
using JovemProgramadorMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace JovemProgramadorMVC.data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapeamento());
            modelBuilder.ApplyConfiguration(new ProfessorMapeamento());
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }

        
        
            
        

       
    }
}
