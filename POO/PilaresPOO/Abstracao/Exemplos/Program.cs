


using Exemplos;

// Gato biroba = new Gato();
// Cachorro tob = new Cachorro();
// Pessoa Maria = new Pessoa();

// Maria.Nome = "Maria";
// Maria.Idade = 17;

// Maria.Dormir();
// Maria.FazerSom();
// Maria.mover();

Console.Clear();

Console.WriteLine($"CONTA CORRENTE:");
ContaCorrente cc = new ContaCorrente(10);
Console.WriteLine($"Saldo inicial da conta  R${cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito:  R${cc.Saldo}");
cc.Depositar(10.01);
Console.WriteLine($"saldo apos saque  R${cc.Saldo}");

Console.WriteLine($"CONTA POUPANCA:");
ContaPoupanca cP = new ContaPoupanca(10);
Console.WriteLine($"Saldo inicial da conta  R${cc.Saldo}");
cc.Depositar(0.5);
Console.WriteLine($"Saldo apos deposito:  R${cc.Saldo}");
cc.Depositar(10.01);
Console.WriteLine($"saldo apos saque  R${cc.Saldo}");                                               



