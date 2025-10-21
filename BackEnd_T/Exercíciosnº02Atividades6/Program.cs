float media, frequencia;

Console.WriteLine("Digite o número da media:");
media = int.Parse(Console.ReadLine());
 
 Console.WriteLine("Digite o número da frequencia:");
frequencia = int.Parse(Console.ReadLine());

if (frequencia >= 75)
{
    Console.WriteLine("aprovado por frequencia:");
}
else
{
    Console.WriteLine("reprovado por frequencia:");
}

if (media >= 7)
{
    Console.WriteLine("aprovado por nota:");
}
else if (media >= 3)
{
    Console.WriteLine("recuperação:");
}
else
{
    Console.WriteLine("reprovado:");
}