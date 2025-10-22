int qtletras = 0;

Console.WriteLine($"ola usuario, quantas letras tem seu nome?");
qtletras = int.Parse(Console.ReadLine());
string nome = "";

for (int i = 1; i <= qtletras; i++)
{
    Console.WriteLine($"qual e a {i}ª letra?");
    nome += Console.ReadLine();
}

Console.WriteLine($"seu nome e: {nome}");




