using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        // Operações Matemáticas simples
        // visipilidade tipoDeRETORNO Nome (parametros){corpo}

        public static float Somar(float a, float b)
        {
            return a + b;
        }

        public static float Subtracao(float a, float b)
        {
            return a - b ;
        }
        public static float Multiplicacao(float a, float b)
        {
            return a * b ;
        }

        public static float Divisao(float a, float b)
        {
            if (b == 0)
            {
                System.Console.WriteLine($"divisão por zero é impossível");
            }
            return a / b ;
        }
    }
}