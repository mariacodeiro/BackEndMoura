using ClasseEObjetos;
Console.WriteLine($"== Sgencia Bancaria ==");
Console.WriteLine();

//AgenciaBancaria contaDoJoao = new AgenciaBancaria;

//contaDoJoao.Titular = "Maria Cordeiro";
//contaDoJoao.Saldo = 1000.98f;

//contaDoJoao.Depositar(-5000);

//contaDoJoao.Sacar(1600);


Produto panela = new Produto();
panela.nome = "Panela de Pressao Tramontina";
panela.preco = 200;

Console.WriteLine($"{panela.nome} custa {panela.preco}");

panela.AplicarDesconto(20);