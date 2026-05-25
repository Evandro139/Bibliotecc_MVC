
using MVC_Biblioteca.Models;

namespace MVC_Biblioteca.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> BuscarPorEmailSenha(string email, string senha);
    }
}