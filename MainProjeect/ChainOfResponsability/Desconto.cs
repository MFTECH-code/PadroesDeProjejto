using MainProjeect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProjeect.ChainOfResponsability
{
    public abstract class Desconto
    {
        protected Desconto Proximo { get; set; }

        public virtual decimal Calcular(Pedido pedido)
        {
            return deveAplicar(pedido) ? aplicar(pedido) : Proximo.Calcular(pedido);
        }

        public abstract bool deveAplicar(Pedido pedido);

        public abstract decimal aplicar(Pedido pedido);
    }
}
