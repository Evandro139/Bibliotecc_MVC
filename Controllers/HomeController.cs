using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Biblioteca.Models;

namespace MVC_Biblioteca.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
