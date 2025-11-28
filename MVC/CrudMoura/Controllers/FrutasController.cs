
using Microsoft.AspNetCore.Mvc;
using Crudmoura.Models;

namespace Crudmoura.Controllers
{

    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public static List<Frutas> listadeFrutas = new List<Frutas>
      {
          new Frutas   { Id = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10, Categoria = "Tropical"},
          new Frutas   { Id = 2, Nome = "Abacaxi", Preco = 6.55f, Quantidade = 15, Categoria = "Tropical"},
          new Frutas   { Id = 3, Nome = "Limão",   Preco = 2.95f, Quantidade = 100, Categoria = "Cítrica"},

      };
        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult ListaFrutas()
        {
            ViewBag.Frutas = listadeFrutas;
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }


        public IActionResult SalvarFruta(Frutas frutasCadastrada)
        {
            frutasCadastrada.Id = listadeFrutas.Max(f => f.Id) + 1;
            listadeFrutas.Add(frutasCadastrada);
            
            Console.WriteLine(frutasCadastrada.Nome);
            Console.WriteLine(frutasCadastrada.Preco);
            Console.WriteLine(frutasCadastrada.Quantidade);
            Console.WriteLine(frutasCadastrada.Categoria);

            return RedirectToAction(nameof(ListaFrutas));

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}