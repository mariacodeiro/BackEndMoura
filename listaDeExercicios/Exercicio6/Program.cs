double media, frequencia;

Console.WriteLine($"Informe a média do aluno: ");
media = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe a frequência do aluno (em %): ");
frequencia = double.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine($"Aluno REPROVADO por falta!");
}
else
{
    if (media >= 7.0)
    {
        Console.WriteLine($"APROVADO!");
    }
    else if (media >= 3.0)
    {
        Console.WriteLine($" RECUPERAÇÃO!");
    }
    else
    {
        Console.WriteLine($"Aluno REPROVADO por nota");
    }
}

Console.WriteLine();