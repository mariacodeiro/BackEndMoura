using Exercicio02;

List<Imprimivel> documentos = new List<Imprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"Menu de Opções
    1) Cadastrar Fatura);
    2) Cadastrar Relatorio
    3) Cadastrar Contrato
    4) Listar Faturas
    5) Listar Relatorios
    6) Listar Contratos
    0) Sair
    Escolha a opção:
    ");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
        Console.WriteLine($"cadastrar fatura em desenvolvimento");
        break;
        case 2:
        Console.WriteLine($"cadastrar Relatorio em desenvolvimento");
        break;
        case 3:
        Console.WriteLine($"cadastrar contrato em desenvolvimento");
        break;
        case 4:
        Console.WriteLine($"cadastrar faturas em desenvolvimento");
        break;
        case 5:
        Console.WriteLine($"cadastrar relatorios em desenvolvimento");
        break;
        case 6:
        Console.WriteLine($"cadastrar contratos em desenvolvimento");
        break;
        case 0:
        Console.WriteLine($"sair");
        break;
        default:
        Console.WriteLine($"opcao invalida");
        break;
        
    }

    Console.WriteLine($"Pressione <ENTER> para continuar");
    Console.ReadLine();
    
} while (opcao != 0);

Console.WriteLine($"digite o nome do cliente devedor");
    string dev = Console.ReadLine();

 Console.WriteLine($"digite o nome da empresa");
    string empresa = Console.ReadLine();
    23
    Console.WriteLine($"digite o valor da fatura");
    string valor = float.Parse(Console.ReadLine());




//funcoes
void cadastrarFaturas()
{
    
    
}
void ListarContratos()
{
    
}
void ListarFaturas()
{
    Console.WriteLine($"Listando faturas");
    foreach(Fatura item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
    
}



















// Fatura fatMadu = new Fatura();
// documentos.Add(fatMadu);

// Fatura fatAle = new Fatura();
// documentos.Add(fatAle);

// Relatorio relMadu = new Relatorio();
//  documentos.Add(relMadu);

// Contrato contMadu = new Contrato();
// documentos.Add(contMadu);


// Console.WriteLine($"FATURA:");
// foreach (var fatura in documentos)
// {
//     if (fatAle is Fatura)
//     {
//         fatAle.Imprimir();
//     }
// }
// Console.WriteLine($"CONTRATOS:");
// foreach (var fatura in documentos)
// {
//     if (fatAle is Contrato)
//     {
//         fatAle.Imprimir();
//     }
// }
// Console.WriteLine($"RELATORIOS:");
// foreach (var fatura in documentos)
// {
//     if (fatAle is Relatorio)
//     {
//         fatAle.Imprimir();
//     }
// }
