using BlogTdsTecnologia.Util;
using System.Threading.Tasks;

namespace BlogTdsTecnologia.Models.UsuarioModel
{
    public class UsuarioBusiness
    {
        private readonly Persistencia _context;

        public UsuarioBusiness(Persistencia context)
        {
            _context = context;
        }

        public async Task<int> CadastrarUsuario(Usuario usuario)
        {
            usuario.Senha = UtilSecurity.ConvertMD5(usuario.Senha);
            _context.Add(usuario);
            int status = await _context.SaveChangesAsync();
            return status;
        }
    }
}
