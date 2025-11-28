using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    

    //acao psdrao inicial
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult MinhaAcao()
    {
        return View(); //retorne a pagina MinhaAcao.cshtml
    }
    public IActionResult ListaNomes()
    {
        string[] nomes = {"anne", "maria", "julio", "fidalgo"};
        ViewBag.Teste = "ola, eu vim atravez da viewBag";
        ViewBag.nomes = nomes;
        return View(); 
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
