using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício2
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public float DiasDeAtroso = 0;
        public float Juros = 0.10f;


        public Fatura(string Dev, string cred, float val, int qtdAtraso)
        {
            Devedor = Dev;
            Credor = cred;
            Valor = val;
            DiasDeAtroso = qtdAtraso;
        }



        public void Imprimir()
        {
            CalcularValorDivida();

            System.Console.WriteLine($@"

Credor: {Credor}
Devedor: {Devedor}
Dias de atraso: {DiasDeAtroso} dia(s)
valor: R${Valor:F2}
juros: R${(Juros * DiasDeAtroso):f2}
Total de júros: R${Valor:F2}



");
            System.Console.WriteLine();
        }
        public void CalcularValorDivida()
        {
            if (DiasDeAtroso > 0)
            {
                Valor = Valor + DiasDeAtroso * Juros;
            }

            if (DiasDeAtroso >= 5)
            {
                System.Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }
    }
}