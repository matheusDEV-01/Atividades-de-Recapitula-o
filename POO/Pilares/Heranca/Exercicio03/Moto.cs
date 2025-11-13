using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Moto : Veiculo
    {
        public string TipoCapacete { get; set; }

        public Moto(string marca, string modelo, string tipoCapacete)
            : base(marca, modelo)
        {
            TipoCapacete = tipoCapacete;
        }

        public virtual void ExibirDado()
        {
            Console.WriteLine($"Moto - Marca: {Marca}, Modelo: {Modelo}, Capacete: {TipoCapacete}");
        }
    }
}