using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CrudMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{

    public class AlunosController : Controller
    {
        private readonly ILogger<AlunosController> _logger;
        public static List<Aluno> listadeAluno = new List<Aluno>
      {
          new Aluno   { Id = 1, Nome = "Moaria", Idade = 5, Materia = "matematica", Cidade = "SP"},
          new Aluno   { Id = 2, Nome = "Anna", Idade = 6, Materia =  "portugues", Cidade= "RJ"},
          new Aluno   { Id = 3, Nome = "Luiz",   Idade = 2, Materia = "ingles", Cidade = "RJ"},

      };
        public AlunosController(ILogger<AlunosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListarAlunos()
        {
            ViewBag.Aluno = listadeAluno;

            return View();
        }
        public IActionResult create()
        {
            return View();
        }
        public IActionResult CreateAlunoaluno()
        {
            return View();
        }


        public IActionResult SalvarFruta(Aluno alunoCadastrada)
        {
            alunoCadastrada.Id = listadeAluno.Max(f => f.Id) + 1;
            listadeAluno.Add(alunoCadastrada);

            Console.WriteLine(alunoCadastrada.Nome);
            Console.WriteLine(alunoCadastrada.Idade);
            Console.WriteLine(alunoCadastrada.Materia);
            Console.WriteLine(alunoCadastrada.Cidade);

            return RedirectToAction(nameof(ListarAlunos));

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}