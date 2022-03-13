using MainProjeect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProjeect.ChainOfResponsability
{
    public class DescontoPorValor : Desconto
    {
        public DescontoPorValor()
        {
            Proximo = new DescontoPorQuantidade();
        }

        public override decimal aplicar(Pedido pedido)
        {
            if (deveAplicar(pedido))
            {
                return pedido.ValorTotal * 0.05m;
            }
            return Proximo.Calcular(pedido);
        }

        public override bool deveAplicar(Pedido pedido)
        {
            if (pedido != null && pedido.ValorTotal >= 100m)
            {
                return true;
            }
            return false;
        }
    }
}
