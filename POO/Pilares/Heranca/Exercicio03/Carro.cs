using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Carro : Veiculo
    {
    public int NumeroDePortas; 

    public Carro(string marca, string modelo, int numeroDePortas)
        : base(marca, modelo)
    {
        NumeroDePortas = numeroDePortas;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Carro - Marca: {Marca}, Modelo: {Modelo}, Portas: {NumeroDePortas}");
    }
    }
}