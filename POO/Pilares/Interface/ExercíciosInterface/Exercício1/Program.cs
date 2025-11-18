using Exercício1;

// Crie uma interface chamada IForma com o método CalcularArea.
// Crie duas classes que implementem essa interface: Retangulo e Circulo.
// No programa, peça os valores necessários e exiba a área calculada para cada forma.
// No Retângulo utilizar o cálculo = Largura * Altura;
// No Círculo utilizar o cálculo = PI * Raio * Raio;
// Extra: Pesquisar sobre a classe Mth do C# e utilizar a constante PI - Math.PI




Console.Clear();
Console.WriteLine("--- Cálculo de Área de Formas Geométricas ---");
System.Console.WriteLine();

System.Console.WriteLine("Vamos calcular o Retângulo:");

//Altura e Largura
Console.Write("Digite a Largura do Retângulo ");
float l = float.Parse(Console.ReadLine());

Console.Write("Digite a Altura do Retângulo: ");
float a = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo();
retangulo.Altura = a;
retangulo.Largura = l;
retangulo.CalcularArea();

Console.WriteLine();
System.Console.WriteLine($"Agora vamos calcular a área do círculo");

System.Console.WriteLine($"Informe o raio do círculo:");
float r = float.Parse(Console.ReadLine());

Circulo circulo = new Circulo();
circulo.Raio = r;
circulo.CalcularArea();

Console.WriteLine();
Console.WriteLine("Cálculos concluídos. Pressione qualquer tecla para sair...");
Console.ReadLine();
