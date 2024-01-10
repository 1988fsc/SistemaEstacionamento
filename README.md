# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

## Contexto
Utilizar os conhecimentos adquiridos no módulo de fundamentos para fazer a manutenção de um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta

A classe Estacionamento contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar

--------------------
# Todo
### AdicionarVeiculo
1A - Solicitado para o usuário digitar uma placa  
1B - Utilizado o método Add da classe List para adicionar na lista "veiculos"

### RemoverVeiculo
2A - Solicita para o usuário digitar a placa e armazenar na variável   
2B - Solicita para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado (utilizado Casting para receber a variável pelo ReadLine)  
2C - Realiza o cálculo : "precoInicial + precoPorHora * horas" para a variável valorTotal.  
2D - Remove a placa digitada da lista de veículos (utilizado o método Remove da classe List)  

### ListarVeiculo
3A - Realizado laço de repetição, exibindo os veículos estacionados (exibindo utilizando interpolação).


- Adicionado try catch para formatos inválido no momento de inserir valor inicial e por hora.


![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)

## 🌐 Socials:
<a href = "mailto:msn.box@outlook.com"><img src="https://img.icons8.com/?size=48&id=WnHyYA2ecNqL&format=png"></a>
[![LinkedIn](https://img.icons8.com/?size=48&id=13930&format=png)](https://www.linkedin.com/in/1988fsc/) 