float salarioRecebido, totalgGasto;

Console.WriteLine("Digite o salário recebido");
salarioRecebido = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o total gasto");
totalgGasto = float.Parse(Console.ReadLine());

if (salarioRecebido > totalgGasto)
{
    Console.WriteLine("Gastos dentro do orçamento");
}
else if (salarioRecebido < totalgGasto)
{
    Console.WriteLine("Orçamento estourado");
}




