using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio05
{
  public class Conta
    {
        public int Numero; 
        public double Saldo; 

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso!");
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque!");
            }
        }
    }
}