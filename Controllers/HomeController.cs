using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace MVC_Bibliotec.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
   
