double l1, l2, l3;

Console.WriteLine($"Informe o primeiro lado do triângulo: ");
l1 = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo lado do triângulo: ");
l2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe o terceiro lado do triângulo: ");
l3 = double.Parse(Console.ReadLine());

if (l1 == l2 && l2 == l3)
{
    Console.WriteLine($"Triângulo Equilátero (3 lados iguais)");
}
else if (l1 == l2 || l1 == l3 || l2 == l3)
{
    Console.WriteLine($"Triângulo Isósceles (2 lados iguais)");
}
else
{
    Console.WriteLine($"Triângulo Escaleno (3 lados diferentes)");
}

Console.WriteLine();
