using CadastroPedidos.Core.Services.Usuario.Dto;
using System.Web.Http;

namespace CadastroPedidos.WebAPI.Controllers
{
    public class PedidosController : ApiController
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidosController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public IHttpActionResult Post(PedidoDto pedido)
        {
            _pedidoRepository.InserirPedido(pedido);
            return Ok();
        }

        public IHttpActionResult Delete(int numchaveidped)
        {
            _pedidoRepository.DeletaPedido(numchaveidped);
            return Ok();
        }
        public IHttpActionResult PutEditaPedido(PedidoDto pedido)
        {
            _pedidoRepository.EditarPedido(pedido);
            return Ok();
        }
    }
}