using APITCC2021.Data;
using APITCC2021.Models;
using APITCC2021.Models.Api;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace APITCC2021.Repositories
{
    public class UsuariosRepo
    {
        private readonly Context _context;
        public UsuariosRepo(Context context)
        {
            _context = context;
        }

        public async Task<dynamic> ValidateLogIn(string email, string password)
        {
            var user = await this.FindUserByEmail(email);
            if (user != null)
            {
                bool isValisPassword = BCrypt.Net.BCrypt.Verify(password, user.Password);
                if (isValisPassword)
                {
                    return user;
                }
            }
            return null;
        }

        public async Task<dynamic> Create(UsuarioForm user)
        {
            var verify = await this.FindUserByEmail(user.Email);

            if (verify == null)
            {
                user.Senha = BCrypt.Net.BCrypt.HashPassword(user.Senha);
                var usuario = new Usuario(user.Nome, user.Email, user.Senha);

                await _context.Usuarios.AddAsync(usuario);
                _context.SaveChanges();

                return new
                {
                    id = usuario.Id,
                    name = usuario.Name,
                    email = usuario.Email,
                };
            }
            else
            {
                throw new System.ArgumentException("E-mail já cadastrado.");
            }
        }

        public async Task<dynamic> DeleteUsuario(int usuarioId)
        {
            var resp = await _context.Usuarios.FindAsync(usuarioId);
            _context.Usuarios.Remove(resp);

            await _context.SaveChangesAsync();

            return "Usuário excluído.";
        }

        public async Task<dynamic> FindUserById(int id)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            if (user != null)
            {
                return user;
            }
            return null;
        }

        private async Task<dynamic> FindUserByEmail(string email)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(x => x.Email == email);
            if (user != null)
            {
                return user;
            }
            return null;
        }
    }
}
