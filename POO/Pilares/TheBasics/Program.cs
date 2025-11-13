using TheBasics;
Console.Clear();

// List<Pessoa> peoples = new List<Pessoa>();

// Endereco enderecoMat = new Endereco();
// enderecoMat.Logradouro = "Rua Niterói";
// //Pessoa com Endereço
// Pessoa mat = new Pessoa(enderecoMat);
// mat.Nome = "Matheus Felix";
// mat.Idade = 17;


// Endereco endAlexia = new Endereco();
// //Pessoa com Endereço
// Pessoa alexia = new Pessoa(endAlexia);
// alexia.Nome = "Matheus Felix";
// alexia.Idade = 17;
// endAlexia.Logradouro = "Rua Niterói";
// endAlexia.Numero = 180;

// //guardando os dados na lista

// peoples.Add(mat);
// peoples.Add(alexia);

// foreach (var p in peoples)
// {
//     System.Console.WriteLine($"Nomes: {p.Nome}");
// }

// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Spíno Teixeira";
// endEnzo.Numero = 3960;
// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Nome = "Enzo";
// pedroEnzo.Curso = "Desenvolvimento de Sistema";
// pedroEnzo.RA = "1234 - xpto";
// pedroEnzo.NotaFinal = 9.75f;

// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua lá de casa";
// endProfAlex.Numero = 988;

// Professor profAlexia = new Professor(endProfAlex);
// profAlexia.Nome = "Aléxia Vitória";

// System.Console.WriteLine($"Aluno {pedroEnzo.Nome} estuda na turma {pedroEnzo.Curso} da profa. {profAlexia.Nome}");

// Carro Toyota = new Carro();
// Toyota.Marca = "Corolla";
// Toyota.Modelo = "Toyota";

// Moto BMW = new Moto();
// BMW.Marca = "BMW";
// BMW.Modelo = "Bmw R-1200-gs";

// Toyota.Ligar();
// Toyota.AbirPortaMala();

// BMW.Ligar();
// BMW.Empinar();



Aviao aviao = new Aviao("Boeing", "747", 6, 4, 416, "Comercial", "LATAM");

aviao.Marca = "Boeing";
aviao.Modelo = "747";
aviao.QtdRodas = 18;
aviao.QtdMotores = 4;
aviao.CapacidadePassageiros = 416;
aviao.Tipo = "Comercial";
aviao.Companhia = "LATAM";

aviao.ExibirDados();

aviao.Ligar();
aviao.Decolar();
aviao.Aterrisar();
aviao.Desligar();