using Exercicio;

PagamentoPix compraPix = new PagamentoPix();
compraPix.ValorCompra = 15000;

float valorPagar = compraPix.CalcularTotal();
Console.WriteLine($"Produto: Blush");
Console.WriteLine($"preco: {compraPix.ValorCompra}");
Console.WriteLine($"tipo de pagamento: Pix");
Console.WriteLine($"Pagamento com desconto: {valorPagar}");


PagamentoCartao compraCartao = new PagamentoCartao();
compraCartao.ValorCompra = 50;

Console.WriteLine($"Produto: caneca");
Console.WriteLine($"preco: {compraPix.ValorCompra}");
Console.WriteLine($"tipo de pagamento: cartao");
Console.WriteLine($"Pagamento com Acrescimo: {compraCartao.CalcularTotal()}");


