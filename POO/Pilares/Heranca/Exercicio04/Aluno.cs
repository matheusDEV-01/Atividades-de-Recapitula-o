using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Aluno : Pessoa
    {
        public string Curso { get; set; }

        public Aluno(string nome, int idade, string curso)
            : base(nome, idade)
        {
            Curso = curso;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Aluno - Nome: {Nome}, Idade: {Idade}, Curso: {Curso}");
        }

    }
}