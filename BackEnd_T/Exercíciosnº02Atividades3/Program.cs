int lado1, lado2, lado3;

Console.WriteLine("Digite as medidas do lado 1");
lado1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite as medidas do lado 2");
lado2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite as medidas do lado 3");
lado3 = int.Parse(Console.ReadLine());
  if (lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("Esse é um triângulo EQUILÁTERO (todos os lados iguais).");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("Esse é um triângulo ISÓSCELES (dois lados iguais).");
        }
        else
        {
            Console.WriteLine("Esse é um triângulo ESCALENO (todos os lados diferentes).");
        }
