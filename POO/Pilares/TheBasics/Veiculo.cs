using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int QtdRodas;

        public void Ligar()
        {
            System.Console.WriteLine($"Ligando o veiculo");
        }

        public void Desligar()
        {
            System.Console.WriteLine("Veiculo desligado");
        }
    }
}