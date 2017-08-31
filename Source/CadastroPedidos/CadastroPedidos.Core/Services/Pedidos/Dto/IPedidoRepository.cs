namespace CadastroPedidos.Core.Services.Usuario.Dto
{
    public interface IPedidoRepository
    {
        void InserirPedido(PedidoDto pedido);
        void EditarPedido(PedidoDto pedido);
        void DeletaPedido(int numchaveidped);
    }
}