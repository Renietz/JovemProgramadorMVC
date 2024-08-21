using JovemProgramadorMVC.data.Mapeamento.Repositorio.Interfaces;
using JovemProgramadorMVC.Models;

namespace JovemProgramadorMVC.data.Mapeamento.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio 
    {

        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Aluno> BuscarAlunos()
        {
            return _bancoContexto.Aluno.ToList();
        }
    }
}
