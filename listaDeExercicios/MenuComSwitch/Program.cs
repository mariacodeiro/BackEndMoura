int opcao = -1;

do
{
    Console.WriteLine($"--------------------------");
    Console.WriteLine($"       Bem Vindo          ");
    Console.WriteLine($"          ao              ");
    Console.WriteLine($"      jacareca food       ");
    Console.WriteLine($"--------------------------");
    Console.WriteLine();
    Console.WriteLine();


    Console.WriteLine($"Escolha uma opção no menu abaixo:");
    Console.WriteLine($"  1)   hot holl------------R$29,90");
    Console.WriteLine($"  2)   temaki--------------R$30,00");
    Console.WriteLine($"  3)   sashimi-------------R$67,90");
    Console.WriteLine($"  4)   yaksoba-------------R$50,90");
    Console.WriteLine($"  5)   Guizola-------------R$59,90");
    Console.WriteLine($"  6)   sair");
    Console.Write($" opcao: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            Console.WriteLine($"Digite <Enter> para continuar...");
            Console.WriteLine();
            break;
        case 1:
            hot holl()
            break;
        case 2:
           temaki()
            break;
        case 3:
            sashimi()
            break;
        case 4:
            yaksoba()
            break;
        case 5:
            guizola()          
          break;
        default:
            Console.WriteLine($"opcao invalida");
            break;
    }

} while (opcao != 0);


void hot holl()
{
  Console.WriteLine($"boa escolha seu rot roll sera entregue em breve");  
}

void temaki()
{
     Console.WriteLine($"boa escolha seu temaki sera entregue em breve");
}

void sashimi()
{   
    Console.WriteLine($"boa escolha seu sashimi sera entregue em breve");
}

void yaksoba()
{
  Console.WriteLine($"boa escolha seu yaksoba sera entregue em breve");  
}

void guizola()
{
  Console.WriteLine($"boa escolha seu guizola sera entregue em breve");  
}



