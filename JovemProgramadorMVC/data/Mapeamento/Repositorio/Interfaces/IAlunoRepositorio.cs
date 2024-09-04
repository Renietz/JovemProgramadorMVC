using JovemProgramadorMVC.Models;

namespace JovemProgramadorMVC.data.Mapeamento.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        List<Aluno> BuscarAlunos();

        void InserirAluno(Aluno aluno);
    }

}
