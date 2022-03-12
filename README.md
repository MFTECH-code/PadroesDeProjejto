# Padrões de Projeto

Neste repositório meu objetivo é fazer uma revisão sobre os padrões de projetos passados em sala de aula.

## Strategy
O Strategy é um padrão de projeto comportamental que permite que você defina uma família de algoritmos, coloque-os em classes separadas, e faça os objetos deles intercambiáveis.

Exemplo de problema que o strategy se encaixa: Imagine uma aplicação de geolocalização que te ajuda a ir de um ponto A para um ponto B calculando a melhor rota possível. Porém na primeira versão dessa aplicação só temos rotas por rodovias.
Para resolver este problema podemos utilizar o padrão de projjeto strategy que cria (Estratégias) diferentes de rotas como a pé, de bicicleta, carro e transporte público.

![](https://cdn.discordapp.com/attachments/811796492410945537/952241897932456007/unknown.png)

 - Fonte de dados: [refactoring.guru](https://refactoring.guru/pt-br/design-patterns/strategy)