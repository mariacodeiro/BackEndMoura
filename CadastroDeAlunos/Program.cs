string[] nomes = new string[3];
int[] idades = new int[3];
int opcao = -1;
int totalAlunos = 0;
do
{
    Console.Clear();
    Console.WriteLine($"=== Aplicativo Sala de Aula");
    Console.WriteLine($" 1) Listar Alunos");
    Console.WriteLine($" 2) Cadastrar Alunos");
    Console.WriteLine($" 0) Sair");
    Console.WriteLine($"Escolho uma opcao");
    opcao = int.Parse(Console.ReadLine());



    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando....");
            break;
        case 1:
            ListarAluno();
            break;
        case 2:
            CadastrarAluno();
            break;
        default:
            break;
    }

    Console.WriteLine($"Pressione <ENTER> para continuar ...");
    Console.ReadLine();



} while (opcao != 0);

void ListarAluno()
{
    Console.WriteLine("=== Listagem de Alunos ===");
}

void CadastrarAluno()
{
    if (totalAlunos >= 3)
    {
        Console.WriteLine($"Limite de vagas atingido");
        return;
    }
    Console.WriteLine("=== Cadastro de Alunos ===");

    Console.WriteLine($"Digite o nome do aluno");
    nomes[totalAlunos] = Console.ReadLine();

    Console.WriteLine("Digite a idade");
    idades[totalAlunos] = int.Parse(Console.ReadLine());
    totalAlunos++;
}
