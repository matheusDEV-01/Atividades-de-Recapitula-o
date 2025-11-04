using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodosConstrutor
{
    public class ClasseProduto
    {
        public string Nome;
        public double Preco;
        public int Estoque;

        public ClasseProduto(string n, double p, int e)
        {
            Nome = n;
            Preco = p;
            Estoque = e;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Nome}, Preço: R${Preco}, Estoque: {Estoque} unidades");
        }
    }
}