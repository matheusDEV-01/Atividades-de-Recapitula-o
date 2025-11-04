using MetodoConstrutor;


//fontes é uma variavel do tipo Pessoa
// Pessoa fontes = new Pessoa("joão", 17);

// // // fontes.Nome = "Felipe Fontes";
// // // fontes.Idade = 17;

// // System.Console.WriteLine(@$"O objeto pessoa que criei é o {fontes.Nome}com a idade
// // {fontes.Idade}");

// // // fontes.Nome = "Gustavo Oliveira";
// // fontes.ExibirDados();

// // // System.Console.WriteLine($"{fontes.Nome}");





//primeiro metodo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas();

System.Console.WriteLine(@$"Primeira Pessoa cadastrada:
                            Nome: {PrimeiraPessoa.Nome}
                            Idade: {PrimeiraPessoa.Idade}

");

//Segunda metodo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("Matheus Felix");
System.Console.WriteLine(@$"Segunda Pessoa cadastrada:
                            Nome: {SegundaPessoa.Nome}
                            Idade: {SegundaPessoa.Idade}

");



//Terceira metodo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas("Felipe Silva", 16);

System.Console.WriteLine($"Digite o seu nome ");
TerceiraPessoa.Nome = Console.ReadLine();

System.Console.WriteLine($"Digite a sua idade");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());

System.Console.WriteLine(@$"Terceira Pessoa cadastrada:
                            Nome: {TerceiraPessoa.Nome}
                            Idade: {TerceiraPessoa.Idade}

");




