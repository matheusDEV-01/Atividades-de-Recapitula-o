using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome;

        public int Idade;

        //metodo construtor de Pessoa, possuindo parametros
        //representam os valores de nome e idade
        //ou seja, estamos inicializando valores para as props ou seja, estamos inicializando valores para as props
        //nome e idade
        public Pessoa(string n, int i)
        {
            Nome = n; //inicializar com o valor de n
            Idade = i;  //inicializar com o valor de i

        }

        public void ExibirDados()
        {
System.Console.WriteLine($"Nome: {Nome} Idade: {Idade}");
        }
    }
}