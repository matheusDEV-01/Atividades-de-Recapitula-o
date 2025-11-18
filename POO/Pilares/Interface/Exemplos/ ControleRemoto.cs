using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ContraleRemoto : IControle
    {
        public int NivelVolume = 99;
        public int VolumeMaximo = 100;

        public void AumentarVolume()
        {
           if (NivelVolume < VolumeMaximo)
           {
            NivelVolume ++;
            System.Console.WriteLine($"Nivél atual do volume {NivelVolume}");
           }
           else
           {
            System.Console.WriteLine($"Volume já atingiu o nível máximo {NivelVolume}");
           }
        }

        public void Desligar()
        {
            System.Console.WriteLine($"Desligando a tv ...");
        }

        public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                System.Console.WriteLine($"O volume já está no mínime {NivelVolume}");
            }
            else
            {
                NivelVolume--;
                Console.WriteLine($"Volume atual: {NivelVolume}");
            }
            
        }

        public void Ligar()
        {
            System.Console.WriteLine($"Ligando a TV ...");
        }
    }
}