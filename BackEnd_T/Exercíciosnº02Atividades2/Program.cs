int golsprimeirotime, golsSegundotime;

Console.WriteLine("gols do primeiro time");
golsprimeirotime = int.Parse(Console.ReadLine());

Console.WriteLine("gols do segundo time");
golsSegundotime = int.Parse(Console.ReadLine());

if (golsprimeirotime > golsSegundotime)
{
    Console.WriteLine("vitória foi do primeiro time");
}
else if (golsprimeirotime == golsSegundotime)
{
    Console.WriteLine("resultado foi um empate");
}
else
{
  Console.WriteLine("vitória foi do segundo time");
}





