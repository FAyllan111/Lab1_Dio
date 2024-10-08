using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ProjetoEstacionamentoDIO.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para ser removido:");
            string placa = Console.ReadLine();
            veiculos.Remove(placa);


            if (veiculos.Any(X => X.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoHora * horas);

                string placaRemover = "";

                Console.WriteLine($" O veículo {placa} foi removido e o preço total foi de: R${valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe,Veiculo não está estacionado aqui. Confira se digitou a placa correta.");
            }
        }

        public void ListarVeiculos()
        {
            if(veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach(string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
        }
    }
}