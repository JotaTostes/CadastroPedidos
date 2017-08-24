using CadastroPedidos.Core.Services.Usuario.Dto;

namespace CadastroPedidos.Core.Services.Usuario
{
    public interface IUsuarioRepository
    {
        void InserirUsuario(UsuarioDto usuario);
        bool VerificaEmailCadastrado(string email);
        bool VerificaEmailSenha(string email, string senha);
        void ValidaEmail(int numchaveusua);
    }
}