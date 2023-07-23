using System;
using Estacionamento.Models;

namespace Estacionamento
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("---------------------------------------\n         Sistema do estacionamento \n---------------------------------------\n\nDigite o preço inicial:");
            double precoInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor adicional cobrado por hora: ");
            double precoHora = double.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(precoInicial, precoHora);

           bool repeticao = true;
          while (repeticao)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção :\n" +
                    "1 - cadastrar veiculo\n" +
                    "2 - remover veiculo \n" +
                    "3 - lista de veiculos\n" +
                    "4 - sair");
                switch (Console.ReadLine())
                {
                    case "1":
                        veiculo.adicionarVeiculo(); 
                        break;

                    case "2":
                        veiculo.removerVeiculo();
                        break;

                    case "3":
                        veiculo.MostrarPlacas();
                        break;
                    case "4":
                        repeticao = false;
                        break;

                    default:
                        Console.WriteLine("opção invalida");
                        break;
                }
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
            }
                
            
        }
    }
}
