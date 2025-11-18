using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício2
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";
        public string PrestadorServico = "";
        public string TextoClausulas = "";

        public Contrato(string contratante, string Contratada, string txtClausulas)
        {
            Contratante = contratante;
            PrestadorServico = Contratada;
            TextoClausulas = txtClausulas;
        }


        public void Imprimir()
        {
            Console.WriteLine($@" 
            Partes:
            Contratante: {Contratante}
            Contratante: {PrestadorServico}
            Cláusulas do Contrato:

            {TextoClausulas}
            --
            
            ");

        }
    }
}