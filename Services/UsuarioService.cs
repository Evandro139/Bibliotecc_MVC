
using MVC_Biblioteca.Models;
using MVC_Biblioteca.Interfaces;


namespace MVC_Biblioteca.Services
{
    public class UsuarioService : IUsuarioService
    {
        
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }


        public async Task<Usuario?> AutenticarUsuario(string email, string senha)
        {
            return await _usuarioRepository.BuscarPorEmailSenha(email, senha);
        }
    }
}
