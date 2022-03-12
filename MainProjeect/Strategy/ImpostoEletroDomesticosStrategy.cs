using MainProjeect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProjeect.Strategy
{
    internal class ImpostoEletroDomesticosStrategy : IImpostoStrategy
    {
        public decimal CalcularImposto(Produto produto)
        {
            // O imposto sob produtos eleetrodomésticos deve ser de 5%
            return produto.Valor * 0.05m;
        }
    }
}
