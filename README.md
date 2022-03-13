# Padrões de Projeto

Neste repositório meu objetivo é fazer uma revisão sobre os padrões de projetos passados em sala de aula.

## Strategy
O Strategy é um padrão de projeto comportamental que permite que você defina uma família de algoritmos, coloque-os em classes separadas, e faça os objetos deles intercambiáveis.

Exemplo de problema que o strategy se encaixa: Imagine uma aplicação de geolocalização que te ajuda a ir de um ponto A para um ponto B calculando a melhor rota possível. Porém na primeira versão dessa aplicação só temos rotas por rodovias.
Para resolver este problema podemos utilizar o padrão de projjeto strategy que cria (Estratégias) diferentes de rotas como a pé, de bicicleta, carro e transporte público.

![](https://cdn.discordapp.com/attachments/811796492410945537/952241897932456007/unknown.png)

 - Fonte de dados: [refactoring.guru](https://refactoring.guru/pt-br/design-patterns/strategy)

 ## Chain of Responsability
 O Chain of Responsibility é um padrão de projeto comportamental que permite que você passe pedidos por uma corrente de handlers. Ao receber um pedido, cada handler decide se processa o pedido ou o passa adiante para o próximo handler na corrente.

Exemplo de problema é a aplicação de descontos em um pedido, sua loja oferece desconto por valor caso o pedido atinja $100, caso não atinja é dado um desconto por quantidade de produtos no pedido, caso tenham sido comprados 10 ou mais produtos o sistema aplica o desconto.
Em vez de fazer um emaranhado de ifs em seu código você pode utilizar dessa corrente de responsabilidade, assim seu código ficará mais adáptavel a mudanças caso você queira criar um desconto novo ou remover um desconto.

![](https://cdn.discordapp.com/attachments/811796492410945537/952616614015172648/unknown.png)

 - Fonte de dados: [refactoring.guru](https://refactoring.guru/pt-br/design-patterns/chain-of-responsibility)