
using Microsoft.AspNetCore.Mvc;
using MVC_Biblioteca.Interfaces;
using MVC_Biblioteca.Models;

namespace MVC_Biblioteca.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logar(string email, string senha)
        {
            Usuario? usuario = await _usuarioRepository
                .BuscarPorEmailSenha(email, senha);

            if (usuario != null)
            {
                HttpContext.Session.SetString(
                    "UsuarioId",
                    usuario.Id.ToString()
                );

                HttpContext.Session.SetString(
                    "Admin",
                    usuario.TipoBib.ToString()
                );

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Erro = "Usuário ou senha inválidos";

            return View("Index");
        }
    }
}