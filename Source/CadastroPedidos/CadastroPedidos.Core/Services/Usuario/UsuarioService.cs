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
            if (_usuarioRepository.VerificaEmailCadastrado(usuario.Email))
            {
                _notification.Add("Usuario ja está cadastrado!!");
                return;
            }
            _usuarioRepository.InserirUsuario(usuario);
        }

        public void GetVerificaEmailCadastrado(string email)
        {
            if (_usuarioRepository.VerificaEmailCadastrado(email))
            {
                _notification.Add("");
            }
        }

        
    }
}