using MainProjeect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProjeect.ChainOfResponsability
{
    public class SemDesconto : Desconto
    {
        public SemDesconto()
        {
            Proximo = null;
        }

        public override decimal aplicar(Pedido pedido)
        {
            return 0;
        }

        public override bool deveAplicar(Pedido pedido)
        {
            return true;
        }
    }
}
