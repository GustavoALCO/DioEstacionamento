using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Estacionamento.Models
{
    public class Veiculo
    {
        private double precoInicial = 0;
        private double precoPorHora = 0;
        private List<string> lista = new List<string>();

        public void adicionarVeiculo()
        {
            Console.WriteLine("Escreva o nome da placa do veiculo para estacionar");
            lista.Add(Console.ReadLine());
        }
        
        public void removerVeiculo()
        {
            Console.WriteLine("qual a placa do veiculo que deseja retirar");
            string placa = Console.ReadLine();

            // verificar se existe a placa na lista 
            if (lista.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas em que o veiculo ficou estacionado : ");
                double horas = Convert.ToDouble(Console.ReadLine());
               double precoTotal = precoInicial + (horas * precoPorHora);
                lista.Remove(placa);
                Console.WriteLine($"O valor que o veiculo da Placa {placa} será de: {precoTotal}");
            
        }
            else
                Console.WriteLine("Desculpe, placa não encontrada");
        }
        public void MostrarPlacas ()
        {
            Console.WriteLine("Placas de carros estacionado no momento");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
        public Veiculo (double precoinicial,double precoHora )
        {
            this.precoInicial = precoinicial;
            this.precoPorHora = precoHora;
        }
    }
}
