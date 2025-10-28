//Arrays
//Criação de Varíaveis
Console.Clear();
string[] nomes = new string[4];//tamanho é 4 - de 0 a 3
int[] idades = new int[4];
int opcao = -1, totalAlunos = 0;

// nomes[0] = "Maria";
// idades[0] = 20;

// nomes[1] = "Matheus";
// idades[1] = 16;

// nomes[2] = "Eloysa";
// idades[2] = 17;

// nomes[3] = "Felipe";
// idades[3] = 17;

// nomes[4] = "José";
// idades[4] = 50


do
{
    Console.WriteLine($"1)Cadastrar Alunos");
    Console.WriteLine($"2)Listar Alunos");
    Console.WriteLine($"0)Sair");
    Console.WriteLine($"Digite uma opção: ");
    opcao = int.Parse(Console.ReadLine());


    //chamar a função correta
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando ...");
            Console.WriteLine($"Pressione <ENTER> para encerrar ...");
            Console.ReadLine();
        break;

        case 1:
            CadastrarAluno();
        break;
        
        case 2:
            ListarAlunos();
        break;

        default:
            Console.WriteLine($"opção Inválida, pressione <ENTER> para continuar ...");
            Console.ReadLine();//para o sistema e espera o usuário digitr Enter!!!
        break;
    }

} while (opcao !=0);


//==================Funções=========================

void CadastrarAluno()
{
    //verificar se tem espaço no array para cadastrar (totalAlunos)
    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Não Limmite de ocupação atingido");
        Console.WriteLine($"Pressione <ENTER> para continuar");
        Console.ReadLine();
        return;
    }
    //pedir os dados para o usuário (nome, idade)
    Console.WriteLine($"Digite o nome do aluno");
    string n = Console.ReadLine();// lê o console, converte em int e guarda em int e guarda o valor digitado na variável temporaria "n"
    Console.WriteLine($"Digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());

    // guardar/cadastrar no array
    nomes[totalAlunos] = n;
    idades[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine($"Aluno cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} alunos(s) cadastrado(s) no sistema!");
    Console.WriteLine($"Pressione <ENTER> para continuar");
    Console.ReadLine();//parar o sistema e esperar o usuário dar um <ENTER>
}



// Função para exibir os alunos
void ListarAlunos()
{

    Console.WriteLine();
Console.WriteLine($"Resultado: ");


for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($" Nome: {nomes[i]}");
    Console.WriteLine($" Idade: {idades[i]} anos");
    Console.WriteLine();
}

    Console.WriteLine($"Pressione <ENTER> para continuar");
    Console.ReadLine();//parar o sistema e esperar o usuário dar um <ENTER>
}

