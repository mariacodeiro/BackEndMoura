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
    Console.WriteLine($"  1) HotRoll  ----------------  R$ 29,90");
    Console.WriteLine($"  2) Temaki    ----------------  R$ 30,00");
    Console.WriteLine($"  3) Sashimi   ----------------  R$ 67,20");
    Console.WriteLine($"  4) Yakisoba  ----------------  R$ 35,90");
    Console.WriteLine($"  5) Guioza    ----------------  R$ 49,90");
    Console.WriteLine($"  6) Shimeji   ----------------  R$ 50,90");
    Console.WriteLine($"  0) Sair");
    Console.Write("\nOpção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"\nSaindo do programa...");
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
            Console.WriteLine($"\nOpção Inválida! Tente novamente.");
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine($"\nDigite <Enter> para continuar...");
        Console.ReadLine();
    }

} while (opcao != 0);

// Funções dos pratos
void HotRoll()
{
    Console.WriteLine($"\nBoa escolha! Vamos preparar seu HotRoll com carinho.");
}

void Temaki()
{
    Console.WriteLine($"\nBoa escolha! Vamos preparar seu Temaki com carinho.");
}

void Sashimi()
{
    Console.WriteLine($"\nBoa escolha! Vamos preparar seu Sashimi com carinho.");
}

void Yakisoba()
{
    Console.WriteLine($"\nBoa escolha! Vamos preparar seu Yakisoba com carinho.");
}

void Guioza()
{
    Console.WriteLine($"\nBoa escolha! Vamos preparar seu Guioza com carinho.");
}

void Shimeji()
{
    Console.WriteLine($"\nBoa escolha! Vamos preparar seu Shimeji com carinho.");
}
