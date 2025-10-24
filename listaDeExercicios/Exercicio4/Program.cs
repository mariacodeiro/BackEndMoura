int senha;

Console.WriteLine($"Digite a senha: ");
senha = int.Parse(Console.ReadLine());

if (senha == 2008)
{
    Console.WriteLine($"PERMITIDO");
}
else
{
    Console.WriteLine($"ACESSO NEGADO");
}

Console.WriteLine();

