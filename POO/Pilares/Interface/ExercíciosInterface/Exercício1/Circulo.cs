using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício1
{
    public class Circulo : IForma
    {
        public float Raio ;
        public float PI = 3.14f ;


        public void CalcularArea()
        {
            System.Console.WriteLine($"A área do círculo é { PI * Raio * Raio}");
        
        }
    }
}