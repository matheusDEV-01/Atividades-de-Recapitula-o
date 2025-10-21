
    int q, contador = 1, numerosDigitados;

        Console.WriteLine("Quantos números você deseja digitar?");
        q = int.Parse(Console.ReadLine());

        while (contador < q)
        {
            Console.WriteLine($"Digite o {contador}º número:");
            numerosDigitados = int.Parse(Console.ReadLine());

    if (numerosDigitados % 2 == 0)
    {
        Console.WriteLine($"Número digitado é par: {numerosDigitados}");

    }
            contador++;
        }



