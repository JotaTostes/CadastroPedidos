namespace CadastroPedidos.Core.Services.Produtos.Dto
{
    public class ProdutosDto
    {
        public int Num_ChaveIdProd { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public string Produto { get; set; }
    }
}