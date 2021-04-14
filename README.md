# Entendendo Programação Orientada a Objeto

## Quem criou?

Alan Kay, é conhecido como um dos principais precursores da programação orientada a objetos, com a criação da linguagem de programação Smalltalk, Mas vale salientar que um pouco antes do lançamento da linguagem Smalltalk algumas noções de POO já eram empregadas na Linguagem Simular 67, criada por Ole-Johan Dahl e Kristen Nygaard em 1967.

## O que é ? 
É uma maneira de escrita de código onde você aproxima o mundo real do mundo digital, onde você ao identificar um *objeto*, você primeiro define "O que é o objeto?", "Quais são as informações que aquele objeto me transmite?", "O que ele faz?", ao responder essas perguntas você, já terá um ideia de como descrever o objeto em seu código.

##Como descrever um objeto em meu código? 
Você irá descrever o seu objeto em uma classe, a classe irá possuir um nome, atributos e métodos.  

## O que é uma classe?
Uma classe é uma maneira de abstrair um objeto do mundo real para o digital, nela você irá descrever quais são os atributos que o objeto do mundo real possuí, e quais são seus comportamentos.

## O que é um atributo?
Atributo é a característica de um objeto, caso o objeto seja um carro temos características como ano, modelo, motor, numero de portas e por aí vai.

## O que é um método? 
Método é os comportamentos que o objeto possuí, seguindo a mesma lógica do veículo : Parar, acelerar, acender farol, apagar farol, acender farol.

## Quais os pilares da POO?
Dependo da literatura você pode encontrar mais pilares,  porém os 4 principais são Abstração, Encapsulamento, Herança e Polimorfismo.

## Abstração
O conceito de abstração ou abstrair, é relacionado a apenas deixar o essencial a ser consumido pela classe, tornando mais simples o uso. Normalmente o uso é realizado por classes abstratas onde, você define o que deve ser feito, e não o como deve ser feito. O como deve ser feito deverá ser implementado por que implementar a classe abstrata.

## Encapsulamento
O ato de encapsular é o ato de deixar visível apenas o necessário para o funcionamento da classe, um bom exemplo é utilizando uma classe veiculo onde você ao acelerar não tem a minima noção de como o carro acelera, apenas tem noção que o carro irá acelerar, caso o carro tenha todo necessário para funcionar.

## Herança
Como o próprio nome diz, a herança vem com o ato de herdar algo, normalmente é realizado entre uma classe e outra, onde uma é conhecida como classe pai e a outra é a classe filha. A classe filha irá conter tudo que a classe Pai contem podendo, adicionar novos ou sobrescrever existentes.

## Polimorfismo
O conceito polimorfismo significa muitas formas, então quer dizer que ao implementar você poderá ter um comportamento que em determinado momento pode assumir mais de um tipo de comportamento. Um exemplo seria o comportamento Andar() na classe carro, pois normalmente o comportamento Andar() significa ir para frente, porém se você engatar a ré do carro o carro irá Andar() para trás, trazendo um comportamento polimórfico.

### Inspirações
[Balta.IO](https://balta.io/blog/orientacao-a-objetos) - Orientação a Objetos
