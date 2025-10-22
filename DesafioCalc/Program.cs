//pedir para o usuario digitar dois numeros e exibir a soma desses dois numeros 

using System.Runtime.InteropServices;

int n1, n2;

Console.WriteLine("digite o primeiro numero");
n1 = int.Parse(Console.ReadLine());


Console.WriteLine("digite o segundo numero");
n2 = int.Parse(Console.ReadLine());


int soma = n1 + n2;

Console.WriteLine($"a soma de {n1} + {n2} E {soma}");
