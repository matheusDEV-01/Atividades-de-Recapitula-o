float nota1, nota2, nota3, nota4, Media;


Console.WriteLine("Digite a primeiro nota");
nota1 = float.Parse(Console.ReadLine());  //converte o texto em número
Console.WriteLine("Digite a segundo nota");
nota2 = float.Parse(Console.ReadLine());  //converte o texto em número
Console.WriteLine("Digite a terceira nota");
nota3 = float.Parse(Console.ReadLine());  //converte o texto em número
Console.WriteLine("Digite a quarta nota ");
nota4 = float.Parse(Console.ReadLine());  //converte o texto em número

Media = (nota1 + nota2 + nota3 + nota4) / 4;
Console.WriteLine("Media da nota" + Media);


if (Media >= 7)
{
    Console.WriteLine("Aprovado: " );
}
else if (Media >= 5)
{
    Console.WriteLine("Reprovado." );
}
else  
{
    Console.WriteLine("Reprovado");
}

