int opcao = -1;

do
{
    Console.Clear();
    Console.WriteLine($"-------------------------");
    Console.WriteLine($"     Bem Vindo           ");
    Console.WriteLine($"         ao              ");
    Console.WriteLine($"    Jacareca Food        ");
    Console.WriteLine($"-------------------------\n");

    Console.WriteLine($"Escolha uma opção no menu abaixo:\n");
    Console.WriteLine($"  1) HotRoll");
    Console.WriteLine($"  2) Temaki");
    Console.WriteLine($"  3) Sashimi");
    Console.WriteLine($"  4) Yakisoba");
    Console.WriteLine($"  5) Guioza");
    Console.WriteLine($"  6) Shimeji");
    Console.WriteLine($"  0) Sair");
    Console.Write("\nOpção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Sair();
            break;
        case 1:
            HotRoll();
            break;
        case 2:
            Temaki();
            break;
        case 3:
            Sashimi();
            break;
        case 4:
            Yakisoba();
            break;
        case 5:
            Guioza();
            break;
        case 6:
            Shimeji();
            break;
        default:
            OpcaoInvalida();
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine($"\nDigite <Enter> para continuar...");
        Console.ReadLine();
    }

} while (opcao != 0);

// Funções para cada opção
void HotRoll()
{
    Console.WriteLine($"Você escolheu HotRoll!");
}

void Temaki()
{
    Console.WriteLine($"Você escolheu Temaki!");
}

void Sashimi()
{
    Console.WriteLine($"Você escolheu Sashimi!");
}

void Yakisoba()
{
    Console.WriteLine($"Você escolheu Yakisoba!");
}

void Guioza()
{
    Console.WriteLine($"Você escolheu Guioza!");
}

void Shimeji()
{
    Console.WriteLine($"Você escolheu Shimeji!");
}

void Sair()
{
    Console.WriteLine($"Saindo do programa...");
}

void OpcaoInvalida()
{
    Console.WriteLine($"Opção inválida! Tente novamente.");
}

