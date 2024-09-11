using JovemProgramadorMVC.data.Mapeamento.Repositorio;
using JovemProgramadorMVC.data.Mapeamento.Repositorio.Interfaces;
using JovemProgramadorMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace JovemProgramadorMVC.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorRepositorio _professorRepositorio;
        public ProfessorController(IProfessorRepositorio professorRepositorio)
        {
            _professorRepositorio = professorRepositorio;
        }
        public IActionResult Index()
        {
            var professor = _professorRepositorio.BuscarProfessor();
            return View(professor);
        }
        public IActionResult AdicionarProfessor()
        {
            return View();
        }

        public IActionResult InserirProfessor(Professor professor)
        {
            try
            {
                _professorRepositorio.InserirProfessor(professor);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Editar(int id)
        {
            var professor = _professorRepositorio.BuscarIdP(id);
            return View(professor);



        }
        public IActionResult EditarProfessor(Professor professor)
        {
            _professorRepositorio.EditarProfessor(professor);
            return RedirectToAction("Index");
        }

        public IActionResult ExcluirP(Professor professor)
        {
            _professorRepositorio.Excluir(professor);
            return RedirectToAction("Index");
        }
    }

}



