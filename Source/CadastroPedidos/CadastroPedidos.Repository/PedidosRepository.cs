using CadastroPedidos.Core.Services.Usuario.Dto;

namespace CadastroPedidos.Repository
{
    public class PedidosRepository : ConnectBD, IPedidoRepository
    {
        private enum Procedures
        {
            GKSSP_InsPedido,
            GKSSP_UpdPedido,
            GKSSP_DelPedido
        }

        public void InserirPedido(PedidoDto pedido)
        {
            ExecuteProcedure(Procedures.GKSSP_InsPedido);
            AddParameter("DataPed", pedido.DataPed);
            AddParameter("Cliente", pedido.Cliente);
            AddParameter("Valor", pedido.Valor);

            ExecuteNonQuery();
        }

        public void EditarPedido(PedidoDto pedido)
        {
            ExecuteProcedure(Procedures.GKSSP_UpdPedido);
            AddParameter("DataPed",pedido.DataPed);
            AddParameter("Cliente",pedido.Cliente);
            AddParameter("Valor",pedido.Valor);

            ExecuteNonQuery();
        }

        public void DeletaPedido(int numchaveidped)
        {
            ExecuteProcedure(Procedures.GKSSP_DelPedido);
            AddParameter("Num_ChaveIdPed",numchaveidped);

            ExecuteNonQuery();
        }
    }
}