using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Professor : Pessoa
    {
        public string Disciplina; 

        public Professor(string nome, int idade, string disciplina)
            : base(nome, idade)
        {
            Disciplina = disciplina;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Professor - Nome: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}");
        }

    }
}