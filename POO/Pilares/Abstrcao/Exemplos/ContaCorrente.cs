using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Exemplos
{
public class ContaCorrente : ContaBancaria
    {
        private double taxaSaque = 5.00; // taxa fixa de saque

        public ContaCorrente(string titular, double saldoInicial)
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
                Console.WriteLine("Saldo insuficiente para saque na conta corrente!");
            }
        }
    }
}