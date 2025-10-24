

double salario, gasto;

    Console.WriteLine("Digite o salário recebido: ");
    salario = double.Parse(Console.ReadLine());
    
        Console.WriteLine("Digite o gasto no mes: ");
        gasto = double.Parse(Console.ReadLine());
  

        if (gasto > salario)
        {
        Console.WriteLine("Gastos dentro do orçamento.");
    }
        else
        {
        Console.WriteLine("Orçamento estourado!");
    }

    
