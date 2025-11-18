using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício1
{
    public class Retangulo : IForma
    {
        public void CalcularArea()
        {
           System.Console.WriteLine($"A área do Retângulo é {Altura * Largura}");
        }
        public float Largura;
        public float Altura;

    }
}