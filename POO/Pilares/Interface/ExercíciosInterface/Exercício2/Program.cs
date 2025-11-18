using System.Diagnostics.Contracts;
using Exercício2;
using Microsoft.VisualBasic;

// Crie uma interface chamada IImprimivel com um método Imprimir.
// Implemente essa interface nas classes Relatorio, Contrato e Fatura.
// Em um programa principal, crie uma lista de objetos e chame o método Imprimir para cada item da lista.

List<IImprimivel> Documentos = new List<IImprimivel>();




int opcao;
do
{

    //Criar um menu da seguinte forma;
    System.Console.WriteLine($"Menu de opções");
    System.Console.WriteLine($@"

1)Cadastro Fatura
2)Cadastro Relatório
3)Cadastro Contrato
4)Listar Fatura
5)Listar Relatório
6)Listar Contrato
0) SAIR
ESCLHA A OPÇÃO: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFatura();
            System.Console.WriteLine($"Cadastro Fatura");
            break;
        case 2:
            CadastrarRelatorio();
            System.Console.WriteLine($"Cadastro Relatorio");
            break;
        case 3:
            CadastrarContrato();
            System.Console.WriteLine($"Cadastro Contrato");
            break;
        case 4:
            ListarFatura();
            System.Console.WriteLine($"Listar Fatura");
            break;
        case 5:
            ListarRelatorio();
            System.Console.WriteLine($"Listar Relatório");
            break;
        case 6:
            ListarContrato();
            System.Console.WriteLine($"Listar Contrato");
            break;
        case 0:
            System.Console.WriteLine($"SAIR");
            break;
        default:
            System.Console.WriteLine($"Opção invalida");
            break;
    }


    System.Console.WriteLine($"Digite <Enter> para Continuar...");
    Console.ReadLine();//Para o console para dar tempo de ver as mensagens do programa

} while (opcao != 0);


void CadastrarFatura()
{
    System.Console.WriteLine($"Digite o nome do devedor");
    string dev = Console.ReadLine();

    System.Console.WriteLine($"Digite o nome do credor");
    string cred = Console.ReadLine();

    System.Console.WriteLine($"Digite o Valor da fatura:");
    float valor = float.Parse(Console.ReadLine());

    System.Console.WriteLine($"Quantos dias a fatura está em atraso ?");
    int diasAtraso = int.Parse(Console.ReadLine());

    //cria o objeto da fatura
    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    //cadastro a fatura na lista
    Documentos.Add(f);
}

void CadastrarContrato()
{
    System.Console.WriteLine($"Digite o nome do  Contratante");
    string con = Console.ReadLine();

    System.Console.WriteLine($"Digite o nome do  Prestador de Serviço");
    string Contratada = Console.ReadLine();

    System.Console.WriteLine($"Digite as Clausulas");
    string txtClausulas = Console.ReadLine();

    //cria o objeto da fatura
    Contrato c = new Contrato(con, Contratada, txtClausulas);
    //cadastro a fatura na lista
    Documentos.Add(c);
}

void CadastrarRelatorio()
{
    System.Console.WriteLine($"Digite o nome");
    string no = Console.ReadLine();

    System.Console.WriteLine($"Digite o texto do Relatorio");
    string txtRelatorio = Console.ReadLine();

    //cria o objeto da fatura
    Relatorio r = new Relatorio(no, txtRelatorio);
    //cadastro a fatura na lista
    Documentos.Add(r);
}

void ListarFatura()
{
    System.Console.WriteLine($"Listando as Faturas:");
    foreach (var item in Documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarRelatorio()
{
    System.Console.WriteLine($"Listando os Relatório:");
    foreach (var item in Documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
}

void ListarContrato()
{
    System.Console.WriteLine($"Listando os Contratos:");
    foreach (var item in Documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
}

// Fatura f = new Fatura("Matheus", "Bradesco Cartões", 1000.98f, 10);



// Relatorio r1 = new Relatorio();
// r1.Imprimir();
// Contrato c1 = new Contrato();
// c1.Imprimir();
// Fatura f1 = new Fatura();
// f1.Imprimir();