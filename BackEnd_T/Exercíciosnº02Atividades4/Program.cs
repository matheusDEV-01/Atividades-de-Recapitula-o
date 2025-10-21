int senhavalida = 1234,  senhainvalida;

Console.WriteLine("Digite a senha");
senhainvalida = int.Parse(Console.ReadLine());



if (senhavalida == senhainvalida)
{
    Console.WriteLine("ACESSO PERMITIDO");
}
else
{
    Console.WriteLine("ACESSO NEGADO");
}
