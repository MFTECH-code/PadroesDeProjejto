using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProjeect.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public IList<Pedido> Items { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusPedido Status { get; set; }
    }

    public enum StatusPedido
    {
        Procesamento = 1,
        Pago = 2,
        Enviado = 3,
        Entregue = 4
    }
}
