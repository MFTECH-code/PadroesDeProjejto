using MainProjeect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProjeect.Strategy
{
    public interface IImpostoStrategy
    {
        decimal CalcularImposto(Produto produto);
    }
}
