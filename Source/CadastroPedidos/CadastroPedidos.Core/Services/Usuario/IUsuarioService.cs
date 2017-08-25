using CadastroPedidos.Core.Services.Usuario.Dto;

namespace CadastroPedidos.Core.Services.Usuario
{
    public interface IUsuarioService
    {
        void InserirUsuario(UsuarioDto usuario);
        void GetVerificaEmailCadastrado(string email);
        void GetVerificaEmailSenha(string email, string senha);
    }
}