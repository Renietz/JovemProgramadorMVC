using JovemProgramadorMVC.Models;

namespace JovemProgramadorMVC.data.Mapeamento.Repositorio.Interfaces
{
    public interface IProfessorRepositorio
    {

            List<Professor> BuscarProfessor();

            void InserirProfessor(Professor professor);

            Professor BuscarIdP(int id);

            void EditarProfessor(Professor professor);

            void Excluir(Professor professor);
        }

    
}

