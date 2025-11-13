using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Cachorro : Animais
    {
           public override void FazerSom()
        {
            Console.WriteLine("Au au!");
        }
    }
}