using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebReports.Models;

namespace WebReports.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Reports()
    {
        return View();
    }
    public IActionResult Clientes()
    {
        var result = new List<ClientesViewModel>()
        {
            new ClientesViewModel()
            {
                Id = 1,
                Nome = "Ana Marica Calixto",
                DataNascimento = "14/06/1972"
            },

            new ClientesViewModel()
            {
                Id = 2,
                Nome = "Ariel Martins Macário",
                DataNascimento = "16/01/2007"
            },

            new ClientesViewModel()
            {
                Id = 3,
                Nome = "Nei de Arruda Nobrega",
                DataNascimento = "10/02/1987"
            },

            new ClientesViewModel()
            {
                Id = 4,
                Nome = "Victor Grilo Barellos",
                DataNascimento = "14/01/2020"
            }
        };

        return View(result);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
