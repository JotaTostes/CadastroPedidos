namespace CadastroPedidos.Core.Services.Produtos.Dto
{
    public interface IProdutosRepository
    {
        void InserirProduto(ProdutosDto produto);
        void DeletarProduto(int numchaveidprod);
    }
}