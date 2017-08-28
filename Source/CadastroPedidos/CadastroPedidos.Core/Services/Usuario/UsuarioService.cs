using CadastroPedidos.Core.Infra;
using CadastroPedidos.Core.Services.Usuario.Dto;

namespace CadastroPedidos.Core.Services.Usuario
{
    public class UsuarioService : IUsuarioService
    {
        private readonly Notification _notification;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(Notification notification, IUsuarioRepository usuarioRepository)
        {
            _notification = notification;
            _usuarioRepository = usuarioRepository;
        }

        public void InserirUsuario(UsuarioDto usuario)
        {
            GetVerificaEmailCadastrado(usuario.Email);
            if (_notification.HasNotification)
                return;
            _usuarioRepository.InserirUsuario(usuario);
        }

        public void GetVerificaEmailCadastrado(string email)
        {
            if (_usuarioRepository.VerificaEmailCadastrado(email))
                _notification.Add("Email ja está cadastrado!!");
        }

        public void GetVerificaEmailSenha(string email, string senha)
        {
            if (_usuarioRepository.VerificaEmailSenha(email,senha))
                _notification.Add("Email e senha ja cadastrado!!");
        }
    }
}