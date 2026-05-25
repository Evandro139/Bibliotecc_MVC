using MVC_Biblioteca.Models;

namespace MVC_Biblioteca.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario?> AutenticarUsuario(string email, string senha);
    }
}