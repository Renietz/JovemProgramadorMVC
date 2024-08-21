using JovemProgramadorMVC.data.Mapeamento.Repositorio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorMVC.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio; 
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
                _alunoRepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
            var aluno = _alunoRepositorio.BuscarAluno();
            return View(aluno);
        }
    }
}
