using MainProjeect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProjeect.Strategy
{
    internal class ImpostoAlimenticiosStrategy : IImpostoStrategy
    {
        public decimal CalcularImposto(Produto produto)
        {
            // O imposto sob produtos alimenticios é de 2%
            return produto.Valor * 0.02m;
        }
    }
}
