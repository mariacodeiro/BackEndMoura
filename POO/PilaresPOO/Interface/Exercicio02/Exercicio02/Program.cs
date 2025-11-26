using Exercicio02;

using System.Data;
using System.Reflection;
using Exercicio02;
// List<Fatura> listafatura = new List<Fatura>();
// List<Relatorio> listaRelatorio = new List<Relatorio>();
// List<Contrato> listaContrato = new List<Contrato>();
List<Imprimivel> Documentos = new List<Imprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"====== Menu de opções ======
    
    1) Cadastrar Fatura
    2) Cadastrar Relatório
    3) Cadastrar Contrato
    4) Listas Faturas
    5) Listar Relatórios
    6) Listar Contratos
    0) Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFaturas();
            break;

        case 2:
            Console.WriteLine($"Cadastrar Relatório em desenvolvimento");
            break;

        case 3:
            Console.WriteLine($"Cadastrar Contratos em desenvolvimento");
            break;

        case 4:
            ListarFaturas();
            break;

        case 5:
            Console.WriteLine($"Listar Relatórios em desenvolvimento");
            break;

        case 6:
            Console.WriteLine($"Listar Contratos em desenvolvimento");
            break;

        case 0:
            Console.WriteLine($"Sair");
            break;

        default:
            Console.WriteLine($"Opção Inválida");
            break;

    }

    Console.WriteLine($"Pressione <<Enter>> para continuar");
    Console.ReadLine();

} while (opcao != 0);



void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do cliente devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura");
    float Valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Dias de atraso da fatura");
    int QtdDiasAtraso = int.Parse(Console.ReadLine());
    
    Fatura fat = new Fatura(dev, empresa, Valor, QtdDiasAtraso);
    Documentos.Add(fat);
}

void CadastrarContratos()
{

    Console.WriteLine($"Digite o Nome do Responsavel:");
    string Nome = Console.ReadLine();

    Console.WriteLine($"Digite o Texto da clasula do contrato:");
    string nome = Console.ReadLine();
    Contrato contrato = new Contrato();
    contrato.nome = Nome;
    contrato.textoClausulas = texto;
    Documentos.Add(contrato);
    Console.WriteLine($"contrato cadastrado com sucesso!");
 

}

void CadastrarRelatorios()
{
  
{
    Console.WriteLine($"Digite o Nome do responsavel:");
    string Nome = Console.ReadLine();
    Console.WriteLine($"Digite o Texto do relatorio:");
    string texto = Console.ReadLine();
     Relatorio relatorio = new Relatorio();
    relatorio.NomeResponsavel = Nome;
    relatorio.TextoRelatorio = texto;
    Documentos.Add(relatorio);
    Console.WriteLine($"relatorio cadastrado com sucesso!");
 

    
}
}

void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in Documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarRelatorios()
{
    
{
    foreach (var item in Documentos)
    {
       if (item is Relatorio)
       {
            item.Imprimir();
       } 
    }
}
}

void ListarContratos()
{
  
{
            Console.WriteLine($"Listando Contratos:");
    foreach (var item in Documentos)
    {
       if (item is Contrato)
       {
            item.Imprimir();
       } 
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
