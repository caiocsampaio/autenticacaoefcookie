using autenticacaoefcookie.Models;

namespace autenticacaoefcookie.Dados
{
    public class CodeFirstBanco
    {
        public static void Inicializar(AutenticacaoContext contexto){
            contexto.Database.EnsureCreated();

            var usuario = new Usuario(){
                Nome = "Jair",
                Email = "ja.ir@terra.com",
                Senha = "12345"
            };

            contexto.Usuarios.Add(usuario);

            var permissao = new Permissao(){
                Nome = "CEO"
            };

            contexto.Permissoes.Add(permissao);

            var usuariopermissao = new UsuarioPermissao(){
                IdUsuario = usuario.IdUsuario,
                IdPermissao = permissao.IdPermissao
            };

            contexto.UsuariosPermissoes.Add(usuariopermissao);
            contexto.SaveChanges();
        }
    }
}