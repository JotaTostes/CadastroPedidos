using CadastroPedidos.Core.Services.Produtos.Dto;
using System.Web.Http;

namespace CadastroPedidos.WebAPI.Controllers
{
    public class ProdutosController : ApiController
    {
        private readonly IProdutosRepository _produtosRepository;

        public ProdutosController(IProdutosRepository produtosRepository)
        {
            _produtosRepository = produtosRepository;
        }

        public IHttpActionResult Post(ProdutosDto produtos)
        {
            _produtosRepository.InserirProduto(produtos);
            return Ok();
        }

        public IHttpActionResult Delete(int numchaveidprod)
        {
                _produtosRepository.DeletarProduto(numchaveidprod);
            return Ok();
        }
    }
}