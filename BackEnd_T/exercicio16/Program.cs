/*Uma empresa decide dar aumento aos funcionários de acordo com o seu cargo, disposto na tabela abaixo

de acordo com a tabela acima faça um programa que receba o cargo e o salario de um funcionário e 
calcule e imprima o salário reajustado*/

string cargo;
double salario, salarioReajustado  ;

Console.WriteLine("Escolha um dos cargos");
Console.WriteLine();
Console.WriteLine(" 1-producao ");
Console.WriteLine(" 2-administrativo ");
Console.WriteLine(" 3-diretoria ");

cargo = Console.ReadLine();


Console.WriteLine("Digite seu salário atual");
salario = double.Parse(Console.ReadLine());



if (cargo == "producao")
{
    salarioReajustado = salario * 1.065;
}

else if (cargo == "administrativo")
{
    salarioReajustado = salario * 1.075;
}

else if (cargo == "diretoriacd")
{
    salarioReajustado = salario * 1.12;
}
else
{
    salarioReajustado = salario;
    Console.WriteLine("Cargo inválido.");
}


Console.WriteLine($"Seu novo salário é: {salarioReajustado}");

