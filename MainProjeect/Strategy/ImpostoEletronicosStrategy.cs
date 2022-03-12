using MainProjeect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProjeect.Strategy
{
    internal class ImpostoEletronicosStrategy : IImpostoStrategy
    {
        public decimal CalcularImposto(Produto produto)
        {
            // O imposto sob produtos eletrônicos é de 7%
            return produto.Valor * 0.07m;
        }
    }
}
