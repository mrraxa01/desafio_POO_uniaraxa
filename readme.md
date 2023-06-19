Desenvolver um projeto Windows Forms ou Console Application, conforme o apresentado a seguir.

Suponha uma estrutura de classes (conforme diagrama), para realizar os métodos matemáticos: multiplicar, somar, subtrair e dividir, além de um método para calcular a média aritmética de uma coleção de valores. 

- A classe Basico representa uma classe de calcular, que armazena internamente dois operandos (X e Y), que devem ser representados por duas propriedades e um resultado R (herdado da classe Calculo). Os valores X e Y podem ser alterados, porém, não podem ser lidos. O valor de R é alterado, de acordo com as chamadas dos métodos que realizam as operações matemáticas. 

- A classe Calculo fornece o valor de R que armazena os resultados dos cálculos. Note que essa classe é abstrata. 

- A propriedade Valoresda classe Estatistico, recebe um Array de valores e Calcula a média aritmética, que será armazenado no R (herdado da classe Calculo). 

- Exemplo de operação: Ao realizar a chamada do método Multiplicar(), deve ser realizado R = X * Y.

- Note que pode ocorrer erro ao realizar a divisão de X por Y, caso o valor de Y seja igual a zero. Então, adicione um tratamento de exceção para tratar este problema.

- Perceba que o usuário deverá adicionar os valores de X e Y ou os Valores do vetor e escolher o tipo do cálculo que será realizado.

- Implemente esta estrutura, observando as especificações, inclusive as restrições de encapsulamento referidas neste enunciado.  

O código fonte do projeto deve ser compactado (ZIP, RAR, 7ZIP) e enviado pelo portal.



Outras dicas:

- Não é necessário retornar valores nos métodos, pois o atributo R, sempre terá o resultado. Veja o exemplo a seguir:



- Note que existem relacionamentos de herança entre as classes Basico e Estatistico, com a classe abstrata Calculo.

- No projeto Console, se achar importante, adicione uma classe para auxiliar na manipulação das outras classes. Esta classe terá: a) parte visual de solicitação dos dados de entrada; b) invocação os métodos para realizar os cálculos; c) apresentação do resultado na tela. 