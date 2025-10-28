//Criar u menu da seguinte forma em loop que chame as funções:
//1. Cadastrar Cliente
//2. Depositar
//3. Sacar
//4. Transferir
//5. listar Clientes
//0. Sair

//Por enquanto, as funções apenas devem exibir uma mensagem "Função em Desenvolvimento"

Console.Clear();
string[] nomes = new string[3];//tamanho é 4 - de 0 a 3
double[] saldos = new double[3];
int[] depositar = new int[4];
int[] transferir = new int[4];
int opcao = -1, totalCliente = 0;






do
{

    Console.Clear();
    Console.WriteLine($" === SISTEMA BANCÁCARIO SIMPLES ===");
    Console.WriteLine();

    Console.WriteLine($"1. Cadastrar Cliente");
    Console.WriteLine($"2. Depositar");
    Console.WriteLine($"3. Sacar");
    Console.WriteLine($"4. Transferir ");
    Console.WriteLine($"5. listar Clientes ");
    Console.WriteLine($"0. Sair ");
    Console.WriteLine($"Escolha uma opção ");
    opcao = int.Parse(Console.ReadLine());


    //chamar a função correta
    switch (opcao)
    {
        case 0:
            Console.WriteLine("Obrigado por usar nosso Sistema Bancario, Encessando...");
            Console.WriteLine("Aperte <ENTER> para continuar...");
            Console.ReadLine();
            break;

        case 1:
            CadastrarCliente();
            break;

        case 2:

            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            ListarClientes();
            break;

        default:
            Console.WriteLine($"Opção Inválida, pressione <ENTER> para continuar");
            Console.WriteLine();
            break;
    }


} while (opcao != 0);

void CadastrarCliente()
{
    if (totalCliente >= 3)
    {
        Console.WriteLine($"Limite de ocupação atingido");
        Console.WriteLine($"Pressione <ENTER> para continuar");
        Console.ReadLine();
        return;
    }
    //Cadastrado o cliente com o saldo inicial zerado!
    Console.WriteLine($"Nome do Cliente");
    nomes[totalCliente] = Console.ReadLine(); //guarda o nome no array
    saldos[totalCliente] = 0; //inicia o saldo zerado
    totalCliente++;

    Console.WriteLine($"Cliente cadastrado com sucesso");
    Console.ReadLine();//parar o sistema e esperar o usuário dar um <ENTER>

}

void Depositar()
{

    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.WriteLine("Valor para depósito");
    double valorDeposito = double.Parse(Console.ReadLine());
    saldos[idCliente] += valorDeposito;
    Console.WriteLine($"Depósito de R${valorDeposito} realizado!");
    System.Console.WriteLine();
    Console.ReadLine();


}

void Sacar()
{
    //buscar o cliente
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    //pedir o valor do saque
    Console.WriteLine($"Valor do saque:");
    double valorSolicitado = double.Parse(Console.ReadLine());
    //validar se pode sacar ou não
    if (saldos[idCliente] >= valorSolicitado)
    {
        //atualizar o saldo da conta
        saldos[idCliente] -= valorSolicitado;
        Console.WriteLine("Saque realizado com sucesso!");
    }
    else
    {
        Console.WriteLine("Saldo insuficiente");
    }


}

int BuscarCliente()
{
    ListarClientes(); //desenha/exibe a lista de cliente
    Console.WriteLine("Digite o número do cliente");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalCliente)
    {
        Console.WriteLine("Cliente não encontrado");
        return -1;//cliente não encontradol
    }

    return idCliente;
}

void Transferir()
{
    //buscar cliente - conta de origem
    //buscar cliente - conta de destino
    //pedir o valor do saque
    //verificar se a conta que tem saldo pra transferir
    //se tiver, trasfere (debita saldo da conta origem e adiciona saldo na conta destino)

    Console.WriteLine($"Conta de Origem:");
    int idClienteOrigem = BuscarCliente();
    if (idClienteOrigem == -1)
    {
        return;
    }
    Console.WriteLine($"Conta de Origem:");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {
        return;
    }
    Console.WriteLine($"Valor para transferir");
    double valor = double.Parse(Console.ReadLine());

    if (saldos[idClienteOrigem] >= valor)
    {
        saldos[idClienteOrigem] -= valor;
        saldos[idClienteDestino] += valor;

        Console.WriteLine($"Transferência concluída!");

    }
    else
    {
        Console.WriteLine($"Saldo insuficiente!");

    }

}

void ListarClientes()
{

    Console.WriteLine("== LISTA DE CLIENTE ==");

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($" {i} - Nome do cliente: {nomes[i]} |{i} - Saldo do cliente: R${saldos[i]:F2}");
        Console.WriteLine();
    }
System.Console.WriteLine();
}







