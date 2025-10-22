// See https://aka.ms/new-console-template for more information
int n1, n2;

Console.WriteLine("digite o primeiro numero");
n1 = int.Parse(Console.ReadLine());


Console.WriteLine("digite o segundo numero");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)

{
    Console.WriteLine($"0 o primeiro numero e o maior: {n1}");
}

else
{
    Console.WriteLine($"0 o segundo numero e o maior: {n2}");
}

{
    Console.WriteLine($"0s numeros sao iguais: {n1} e {n2}");
}