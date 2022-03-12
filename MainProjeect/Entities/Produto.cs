using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProjeect.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public TipoDeProduto Tipo { get; set; }
    }

    public enum TipoDeProduto
    {
        Eletronico = 1,
        EletroDomestico = 2,
        Alimenticio = 3
    }
}
