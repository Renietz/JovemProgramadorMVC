﻿using JovemProgramadorMVC.data.Mapeamento.Repositorio.Interfaces;
using JovemProgramadorMVC.Models;
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
            var aluno = _alunoRepositorio.BuscarAlunos();
            return View(aluno);
        }
        public IActionResult AdicionarAluno()
        {
            return View();
        }

        public IActionResult InserirAluno(Aluno aluno)
        {
            try
            {
                _alunoRepositorio.InserirAluno(aluno);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
        public IActionResult Editar(int id)
        {
            var aluno = _alunoRepositorio.BuscarId(id);
            return View(aluno);



        }
        public IActionResult EditarAluno(Aluno aluno)
        {
            _alunoRepositorio.EditarAluno(aluno);
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(Aluno aluno)
        {
            _alunoRepositorio.Excluir(aluno);
            return RedirectToAction("Index");
        }
    }
}


