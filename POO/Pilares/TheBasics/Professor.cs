using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Professor : Pessoa
    {
        public Professor(Endereco endereco) : base(endereco)
        {
        }

        public float Salario;


    }
}