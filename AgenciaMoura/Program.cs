using System.Runtime.Intrinsics.X86;

string[] nome = new string[10];
float[] saldos = new float[10];
int totalClientes = 0;

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"=== SISTEMA BANCÁRIO SIMPLES ===");
    Console.WriteLine($"1) Cadastrar Cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5) Listar Clientes");
    Console.WriteLine($"0) Sair");
    Console.Write($" Escolha uma opção: ");
    Console.WriteLine($"");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {

        case 0:
       
        Console.WriteLine($"encerrando o programa...");
        
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
            Transferencia();
            break;

        case 5:
            ListarClientes();
            break;

        default:
        Console.WriteLine($"Opção inválida, tente novamente");
        
            break;
    }


    //ao final de cada opção, faz uma parada no sistema 
    Console.WriteLine($"Precione <ENTER> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarCliente()
{
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite clientes atingido");
        return; //para a função aqui, não execulta o código abaixo
    }

    Console.WriteLine("Digite o nome do cliente");
    nome[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;

    totalClientes++;

    Console.WriteLine($"Cliente cadastrado com êxito!");
}

void Depositar()
{ 
    //Retorna o índice do array onde o cliente está armazenado
    //assim eu posso usar de base para guardar o saldo do cliente

    int idCliente = BuscarCliente();
    if (idCliente == -1) return; //cliente não encontrado

    //cliente encontrado
    Console.Write($"Valor para depósito: R$");
    float valor = float.Parse(Console.ReadLine());
    saldos[idCliente] += valor;
    Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
    

}

void Sacar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1) return; //cliente não encontrado

    Console.Write($"Valor pra saque: R$: ");
    float valor = float.Parse(Console.ReadLine());

    if (saldos[idCliente] >= valor && valor >0)
    {
        saldos[idCliente] -= valor;
        Console.WriteLine($"Saque realizado com sucesso!");
    }
    else
    {
        Console.WriteLine($"Saldo insuficiente!");
        
    }
}

void Transferencia()
{
    Console.WriteLine($"== Transferência ==");
    Console.Write($"Conta de origem: ");
    int idOrigem = BuscarCliente();

    if (idOrigem == -1) return;

    Console.Write($"Conta de Destino: ");
    int idDestino = BuscarCliente();

    if (idDestino == -1) return;

    Console.Write($"Valor para transferir: ");
    float valor = float.Parse(Console.ReadLine());

    if (saldos[idDestino] >= valor && valor > 0) 
    {
        //transfere de boa
        saldos[idOrigem] -= valor;
        saldos[idDestino] += valor;
        Console.WriteLine($"Transferencia concluída!");
        
    }
    else
    {
        Console.WriteLine($"Saldo Insuficiente!!!");
        
    }
}

void ListarClientes()
{
    Console.WriteLine($"== Lista de Clientes ==");

    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i} - {nome[i]} | Saldo: R$: {saldos[i]}");
        Console.WriteLine();

    }
}

int BuscarCliente()
{

    //listar cliente
    ListarClientes();

    //pedir pro usuário escolher o cliente
     Console.Write($"Digite o número do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());
    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente não encontrado");
        return -1;
    }

    //retornar/devolver o id do cliente
    return idCliente;
}