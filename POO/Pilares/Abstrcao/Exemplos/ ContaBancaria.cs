using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public abstract class ContaBancaria
    {
        public string Titular; 
        public double Saldo; 

        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"{Titular} depositou R${valor:0.00}. Saldo atual: R${Saldo:0.00}");
        }

        public abstract void Sacar(double valor);
    }
}