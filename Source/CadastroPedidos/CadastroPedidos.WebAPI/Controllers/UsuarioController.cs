using CadastroPedidos.Core.Infra;
using CadastroPedidos.Core.Services.Usuario;
using CadastroPedidos.Core.Services.Usuario.Dto;
using System.Net;
using System.Web.Http;

namespace CadastroPedidos.WebAPI.Controllers
{
    public class UsuarioController : ApiController

    {
        private readonly Notification _notification;
        private readonly IUsuarioService _usuarioService;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(Notification notification, IUsuarioService usuarioService, IUsuarioRepository usuarioRepository)
        {
            _notification = notification;
            _usuarioService = usuarioService;
            _usuarioRepository = usuarioRepository;
        }

        public IHttpActionResult Post(UsuarioDto usuario)
        {
            _usuarioService.InserirUsuario(usuario);
            if (_notification.HasNotification)
                return Content(HttpStatusCode.NotAcceptable, _notification.GetNotification);
            return Ok();
        }

        public IHttpActionResult GetVerificaEmailCadastrado(string email)
        {
            _usuarioService.GetVerificaEmailCadastrado(email);
            if (_notification.HasNotification)
                return BadRequest();
            return Ok();
        }

        public IHttpActionResult GetVerificaEmailSenha(string email, string senha)
        {
            _usuarioService.GetVerificaEmailSenha(email, senha);
            if (_notification.HasNotification)
                return BadRequest();
            return Ok();
        }

        public IHttpActionResult GetValidaEmail(int numChaveUsua)
        {
            _usuarioRepository.ValidaEmail(numChaveUsua);
            return Ok();
        }
    }
}