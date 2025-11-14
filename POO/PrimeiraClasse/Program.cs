
using System.ComponentModel.DataAnnotations;
using PrimeiraClasse;

 Console.WriteLine($"===== PROGRAMA PRIMEIRA CLASSE =====");
// Carro mclaren = new Carro();
// mclaren.marca = "Mclaren";
// mclaren.cor = "laranja";
// mclaren.modelo = "750s";
// mclaren.potencia = "800";


// Console.WriteLine($"Ligando a {mclaren.marca}  {mclaren.potencia} cv");
// mclaren.Ligar();

// Console.WriteLine($"Acelerando a {mclaren.marca} de {mclaren.potencia} cv");
// mclaren.Acelerar();

//pessoa madu = new Pessoa();
//madu.Nome = "Maria Eduarda";
//madu.Idade = "17"
//madu.Altura = "166"

// Garrafa Tupperware = new Garrafa();
// Tupperware.cor = "roxo";
// Tupperware.Capacidade = "500";
// Tupperware.tamanho = "27";
// Tupperware.Formato = "arredondada";
// Tupperware.Abrir();
// Tupperware.Beber();

// Garrafa Stanley = new Garrafa();
// Stanley.cor = "azul goiaba";
// Stanley.Capacidade = "500ml";

Pessoa madu = new Pessoa();
madu.Nome = "Maria Eduarda";
madu.Altura = 155;

Console.WriteLine($"{madu.Nome} tem {madu.Idade} anos");
madu.Envelhecer();
Console.WriteLine($"{madu.Nome} TimeOnly {madu.Idade} anos");







