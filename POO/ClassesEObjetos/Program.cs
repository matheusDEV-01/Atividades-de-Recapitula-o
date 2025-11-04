

using ClassesEObjetos;


// Garrafa g1 = new Garrafa();

// Console.Clear();
// Console.WriteLine("=== MONTE SUA GARRAFA ===");
// Console.WriteLine("----------------------------");

// Console.Write("Digite a marca da garrafa: ");
// g1.marca = Console.ReadLine();

// Console.Write("Digite o modelo da garrafa: ");
// g1.modelo = Console.ReadLine();

// Console.Write("Digite a cor da garrafa: ");
// g1.cor = Console.ReadLine();

// Console.Write("Digite a capacidade (em litros): ");
// g1.capacidade = double.Parse(Console.ReadLine());

// Console.Clear();
// Console.WriteLine("=== SUA GARRAFA FOI MONTADA ===");
// Console.WriteLine($"Marca: {g1.marca}");
// Console.WriteLine($"Modelo: {g1.modelo}");
// Console.WriteLine($"Cor: {g1.cor}");
// Console.WriteLine($"Capacidade: {g1.capacidade}L");
// Console.WriteLine("----------------------------");

// // Testando os métodos
// Console.WriteLine("\nAgora vamos testar as funções da garrafa:");
// g1.abrir();
// g1.encher();
// g1.fechar();
// g1.abrir();
// g1.esvaziar();
// g1.fechar();



AgênciaBancária b1 = new AgênciaBancária();

Console.Clear();
Console.WriteLine("=== Agência Bancária ===");
Console.WriteLine("----------------------------");

Console.WriteLine($"Nome do titular");
b1.titular = Console.ReadLine();

b1.Depositar();

Console.WriteLine($"Depósito de {b1.Depositar} realizado!");

Console.WriteLine($"Valor do saldo: {b1.saldo}");
b1.Sacar();

Console.WriteLine($"Valor do saldo: {b1.saldo}");





ProdutocomDesconto p1 = new ProdutocomDesconto();

            Console.Write("Digite o nome do produto: ");
            p1.nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            p1.preco = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de desconto: ");
            double desconto = double.Parse(Console.ReadLine());

            p1.AplicarDesconto(desconto);









// Pessoa joao = new Pessoa();

// joao.Nome = "João Silva";
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// joao.Envelhecer(17);
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// int novaIdade = joao.Envelhecer(17);//atualizaa idade e devolve a idade
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// joao.Envelhecer(-50);//devolve a idade antiga: 17
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");