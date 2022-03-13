using MainProjeect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProjeect.ChainOfResponsability
{
    public class DescontoPorQuantidade : Desconto
    {
        public DescontoPorQuantidade()
        {
            Proximo = new SemDesconto();
        }

        public override decimal aplicar(Pedido pedido)
        {
            if (deveAplicar(pedido))
            {
                return pedido.ValorTotal * 0.1m;
            }
            return Proximo.Calcular(pedido);
        }

        public override bool deveAplicar(Pedido pedido)
        {
            if (pedido != null && pedido.Items.Count >= 10)
            {
                return true;
            }
            return false;
        }
    }
}
