using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class Moto
    {
        //propriedade
        public int qqqRodas;
        public string modelo = "";

        public string marca = "";

        public string cor = "";

        //métodos
        public void Acelerar()
        {
            Console.WriteLine($"Carro Acelerando");

        }
        public void Frear()
        {
            Console.WriteLine($"Carro Freando");
        }

        public void Ligar()
        {
            Console.WriteLine($"Carro Ligando");
        }
        public void Desligar()
        {
            Console.WriteLine($"Carro Desligar");
        }

    }
}
