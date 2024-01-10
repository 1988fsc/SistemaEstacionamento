using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: 1A- Pedir para o usuário digitar uma placa (ReadLine) e 1B- adicionar na lista "veiculos"

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();//1-Criado a variável para conter o valor digitado
            veiculos.Add(placa); //1B -utilizando o método Add da classe List

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine(); // 2A - Solicita para o usuário digitar a placa e armazenar na variável 

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                // TODO: 2B - Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
                int horas = int.Parse(Console.ReadLine()); // Foi necessário utilização do Casting para receber a variável como int pelo Readline.

                decimal valorTotal = precoInicial + (precoPorHora * horas); // TODO: 2C -Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal

                veiculos.Remove(placa); //TODO: 2D - Remover a placa digitada da lista de veículos -utilizando o método Remove da classe List

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: 3A - Realizar um laço de repetição, exibindo os veículos estacionados - exibindo utilizando interpolação.
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"Veículo placa - {veiculo}");
                }


            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
