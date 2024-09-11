using JovemProgramadorMVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JovemProgramadorMVC.data.Mapeamento
{ 
       public class ProfessorMapeamento : IEntityTypeConfiguration<Professor>
        {
            public void Configure(EntityTypeBuilder<Professor> builder)
            {
                builder.ToTable("Professor");

                builder.HasKey(t => t.Id);

                builder.Property(t => t.Nome).HasColumnType("varchar(40)");
                builder.Property(t => t.Disciplina).HasColumnType("varchar(20)");
                builder.Property(t => t.Sala).HasColumnType("varchar(15)");
            }
        }
    
}
