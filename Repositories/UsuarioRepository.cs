using Microsoft.EntityFrameworkCore;
using MVC_Biblioteca.Contexts;
using MVC_Biblioteca.Models;
using MVC_Biblioteca.Interfaces;

namespace MVC_Biblioteca.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BibliotecDb _context; 
        public UsuarioRepository(BibliotecDb context)
        {
            _context = context;
        }
          public async Task<Usuario?> BuscarPorEmailSenha(string email, string senha)
            {
                return await _context.Usuario.FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);
            }

    }
}