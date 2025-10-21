Console.WriteLine("Hello, World!");

int numero1;
int numero2;

Console.WriteLine("Digite o primeiro numero");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine("primeiro numero é maior: " + numero1);
}
else if (numero1 == numero2)
{
    Console.WriteLine($"Os números são iguais. {numero1} e {numero2}");
}
else
{
    Console.WriteLine($"segundo numero é maior: {numero2}");
}
