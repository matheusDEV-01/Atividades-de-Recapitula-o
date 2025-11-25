// See https://aka.ms/new-console-template for more information
using ClassesEstaticas;

Console.WriteLine("Bem vindo ao programa");
System.Console.WriteLine();

// System.Console.WriteLine($"Digite um número:");
// float a = float.Parse(Console.ReadLine());

// System.Console.WriteLine($"Digite outro número:");
// float b = float.Parse(Console.ReadLine());

// //uso da classe estática de forma auxiliar
// float r = CalculosMatematicos.Somar(a, b);
// System.Console.WriteLine($"Soma: {r}");

// r = CalculosMatematicos.Subtracao(a, b);
// System.Console.WriteLine($"Subtração: {r}");

// r = CalculosMatematicos.Multiplicacao(a, b);
// System.Console.WriteLine($"multiplicação: {r}");

// r = CalculosMatematicos.Divisao(a, b);
// System.Console.WriteLine($"Divisão: {r}");

// Solicitar ao usuário 2 números reais e infor mar qua é o maior e qual é o menor dos
//números. Para isso você deve utilizar a clesse Math, utilitária do C#endregion

System.Console.WriteLine($"Digite um número:");
float a = float.Parse(Console.ReadLine());

System.Console.WriteLine($"Digite outro número:");
float b = float.Parse(Console.ReadLine());

if (a == b)
{
    System.Console.WriteLine($"Os dois números são iguais");
}
else
{
    float Maior = Math.Max(a, b);
    System.Console.WriteLine($"O maior número é: {Maior}");

    float Menor = Math.Min(b, a);
    System.Console.WriteLine($"O Menor número é: {Menor}");
}




