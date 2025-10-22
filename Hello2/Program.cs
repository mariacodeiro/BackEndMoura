//pedir para o usuario digitar o nome, sobrenome, idade, saldo bancario, e quanto investiu esse ano

string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float investimentos;

Console.WriteLine("ola, qual e o seu nome");
nome = Console.ReadLine();

Console.WriteLine("ola, qual e o seu sobrenome");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("ola, qual e a sua idade");
idade = int.Parse (Console.ReadLine());

Console.WriteLine("ola, qual e o seu saldo bancario?");
saldoBancario = float.Parse(Console.ReadLine());



Console.WriteLine("ola, qual e o seu investimento?");
investimentos = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine($"nome: {nome}  {sobrenomeDoFulano}");
Console.WriteLine($"idade do {nome} e {idade}");
Console.WriteLine($"saldo bancario: {saldoBancario}");
Console.WriteLine($"investimento esse ano: {investimentos}");





