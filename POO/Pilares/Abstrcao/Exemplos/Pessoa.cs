using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Pessoa : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine($"Olá Olá");
        }

        public override void Mover()
        {
            System.Console.WriteLine($"Ploc Ploc Ploc");
        }
    }
}