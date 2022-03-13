using MainProjeect.ChainOfResponsability;
using MainProjeect.Entities;
using MainProjeect.Strategy;
using System;
using System.Collections.Generic;

namespace MainProjeect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produtos = new List<Produto>();

            for (int i = 1; i <= 10; i++)
            {
                produtos.Add(new Produto { 
                    Id = i,
                    Nome = "Produto gerado",
                    Tipo = TipoDeProduto.Eletronico,
                    Valor = 5m
                });
            }

            var valorTotal = 0m;
            foreach (var produto in produtos)
            {
                valorTotal += produto.Valor;
            }

            var pedido = new Pedido
            {
                Id = 1,
                Items = produtos,
                Status = StatusPedido.Procesamento,
                ValorTotal = valorTotal
            };

            // Aplicando desconto por valor
            var desconto = new DescontoPorValor();
            var descontoAplicado = desconto.Calcular(pedido);

            Console.WriteLine(descontoAplicado);
        }
    }
}
