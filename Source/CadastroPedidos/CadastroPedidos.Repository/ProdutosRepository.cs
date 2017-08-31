using CadastroPedidos.Core.Services.Produtos.Dto;

namespace CadastroPedidos.Repository
{
    public class ProdutosRepository : ConnectBD , IProdutosRepository
    {
        private enum Procedures
        {
            GKSSP_InsProd,
            GKSSP_DelProduto
        }

        public void InserirProduto(ProdutosDto produto)
        {
            ExecuteProcedure(Procedures.GKSSP_InsProd);
            AddParameter("Quantidade", produto.Quantidade);
            AddParameter("Produto", produto.Produto);
            AddParameter("ValorUnitario", produto.ValorUnitario);
            ExecuteNonQuery();
        }

        public void DeletarProduto(int numchaveidprod)
        {
            ExecuteProcedure(Procedures.GKSSP_DelProduto);
            AddParameter("Num_ChaveIdProd", numchaveidprod);
            ExecuteNonQuery();
        }
    }
}