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

        public UsuarioController(Notification notification, IUsuarioService usuarioService)
        {
            _notification = notification;
            _usuarioService = usuarioService;
        }

        public IHttpActionResult Post(UsuarioDto usuario)
        {
            _usuarioService.InserirUsuario(usuario);
            if (_notification.HasNotification)
                return Content(HttpStatusCode.NotAcceptable, _notification.GetNotification);

            return Ok();
        }

    }
}