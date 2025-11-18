using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício2
{
    public class Relatorio : IImprimivel
    {
        public string Nome = "";
        public string textoRelatorio = "";

        public Relatorio(string resposavel, string txtRelatorio)
        {
            Nome = resposavel;
            textoRelatorio = txtRelatorio;
        }


        public void Imprimir()
        {
            Console.WriteLine($"Resposável: {Nome}... ");
            System.Console.WriteLine(textoRelatorio);
            System.Console.WriteLine("---------");
        }
    }
}