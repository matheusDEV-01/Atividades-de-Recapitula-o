using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float SaldoInicial)
        {
            if (SaldoInicial > 0)
            {
                Saldo = SaldoInicial;
                return;
            }

        }

        //Método público que seta/configura/guarda
        public void Depositar(float valor)
        {
            if (valor >= 0)
            {
                Saldo = valor;
                return;
            }

            System.Console.WriteLine($"Valor para depósito inválido");

        }


        //Método público que retorna o Saldo
        public float GetSaldo()
        {
            return Saldo;
        }

        //crie o método público Sacar(float valor)
        public void Sacar(float valor)
        {
            if (valor <= Saldo)
            {
                System.Console.WriteLine($"Saque realizado com sucesso");
            }
            
            else
            {
                System.Console.WriteLine($"Saldo inválido");
            }
            Saldo -= valor;
        }
    }
}