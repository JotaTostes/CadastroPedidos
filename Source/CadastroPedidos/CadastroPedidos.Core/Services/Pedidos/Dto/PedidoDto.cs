using System;

namespace CadastroPedidos.Core.Services.Usuario.Dto
{
    public class PedidoDto
    {
        public int Num_ChaveIdPed { get; set; }
        public DateTime DataPed { get; set; }
        public string Cliente { get; set; }
        public decimal Valor { get; set; }
    }
}