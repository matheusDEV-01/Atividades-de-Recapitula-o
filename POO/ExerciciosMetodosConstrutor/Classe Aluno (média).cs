using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodosConstrutor
{
    public class Aluno
    {
        public string nome = "";
        public double n1, n2, n3;

        //construtor com parâmetros
        public Aluno(double param1, double param2, double param3)
        {
            n1 = param1;
            n2 = param2;
            n3 = param3;
        }

        public Aluno()
        {
            n1 = n2 = n3 = 0;
        }


        public void media()
        {
            double media = (n1 + n2 + n3) / 3;
            System.Console.WriteLine($"A média do (a) {nome}, foi {media}❤️");
        }
    }
}
