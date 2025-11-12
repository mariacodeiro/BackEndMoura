using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
namespace ClasseEObjetos
public class AgenciaBancaria
{
    public string Titular;
    public float Saldo;

    public void Depositar(float valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito efetuado  R$ {valor:}");
        Console.WriteLine($"Saldo atual: {Saldo:F2}");
    }

    public void Sacar(float valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para o saque");
        }
        Console.WriteLine($"Saldo atual: R$ {Saldo:F2}\n");
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria conta = new ContaBancaria();

        Console.Write("Digite o nome do titular da conta: ");
        conta.Titular = Console.ReadLine();

        Console.WriteLine($"\nBem-vindo, {conta.Titular}!");
        Console.WriteLine($"Saldo inicial: R$ {conta.Saldo:F2}\n");

        conta.Depositar(500);   
        conta.Sacar(200);     
        conta.Sacar(400);       
    }
}
