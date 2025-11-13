using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Aviao : Veiculo
    {
        public int QtdMotores;
        public int CapacidadePassageiros;
        public string Tipo;
         public int QtdRodas;
        public string Companhia;

public Aviao(string marca, string modelo, int qtdRodas, int qtdMotores, int capacidade, string tipo, string companhia)
    {
        Marca = marca;
        Modelo = modelo;
        QtdRodas = qtdRodas;
        QtdMotores = qtdMotores;
        CapacidadePassageiros = capacidade;
        Tipo = tipo;
        Companhia = companhia;
    }

        public void Decolar()
        {
            Console.WriteLine("O avião decolou!");
        }

        public void Aterrisar()
        {
            Console.WriteLine("O avião aterrissou!");
        }
         public void Ligar()
        {
            System.Console.WriteLine($"Ligando o avião");
        }

        public void Desligar()
        {
            System.Console.WriteLine("avião desligado");
        }
         public void ExibirDados()
        {
            Console.WriteLine($" QtdMotores: { QtdMotores},  Capacidade Passageiros: {CapacidadePassageiros},  QtdRodas: {QtdRodas} Tipo: {Tipo} Companhia:{Companhia} Marca: {Marca} Modelo: {Modelo}");
        }
    }
}
