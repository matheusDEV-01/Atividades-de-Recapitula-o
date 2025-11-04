using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodosConstrutor
{
    public class ClasseAluno
    {
        public string Nome;
        public double Nota;

        public ClasseAluno ()
        {
            Nome = "Desconhecido";
            Nota = 0;
        }

        public ClasseAluno(string nome, double nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Aluno: {Nome}, Nota: {Nota}");
        }
    }
}