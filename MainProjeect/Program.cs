using MainProjeect.Entities;
using MainProjeect.Strategy;
using System;

namespace MainProjeect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produto1 = new Produto 
            {
                Id = 1,
                Nome = "Notebook",
                Valor = 1900m,
                Tipo = TipoDeProduto.Eletronico
            };

            var produto2 = new Produto
            {
                Id = 2,
                Nome = "Batata",
                Valor = 5m,
                Tipo = TipoDeProduto.Alimenticio
            };

            // Calculando imposto do notebook

            // Selecionamos o tipo de imposto que queremos utilizar
            IImpostoStrategy estrategiaDeImposto = new ImpostoEletronicosStrategy();

            // Calculamos o imposto
            var imposto = estrategiaDeImposto.CalcularImposto(produto1);

            Console.WriteLine(imposto);

            // Calculando imposto da batata

            // Podemos trocar de estratégia quando quisermos
            estrategiaDeImposto = new ImpostoAlimenticiosStrategy();

            imposto = estrategiaDeImposto.CalcularImposto(produto2);

            Console.WriteLine(imposto);

            // Se quisermos podemos criar uma validação depenendo do tipo de produto
        }
    }
}
