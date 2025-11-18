using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
   public class ContaPoupanca : ContaBancaria
    {
        private double taxaSaque = 2.00; // taxa menor para poupança

        public ContaPoupanca(string titular, double saldoInicial)
            : base(titular, saldoInicial) { }

        public override void Sacar(double valor)
        {
            double total = valor + taxaSaque;
            if (Saldo >= total)
            {
                Saldo -= total;
                Console.WriteLine($"{Titular} sacou R${valor:0.00} (Taxa: R${taxaSaque:0.00}). Saldo atual: R${Saldo:0.00}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque na conta poupança!");
            }
        }
    }

}