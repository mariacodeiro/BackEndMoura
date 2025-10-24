
int gols1, Time2;

Console.WriteLine($"digite os gols do primeiro time: ");
gols1 = int.Parse(Console.ReadLine());

Console.WriteLine($"digite os gols do segundo time: ");
Time2 = int.Parse(Console.ReadLine());

if (gols1 == Time2)
{
    Console.WriteLine($"empate");
}
else if (gols1 > Time2)
{
    Console.WriteLine($"Vitória do PRIMEIRO time!");
}
else
{
    Console.WriteLine($"Vitória do SEGUNDO time!");
}

Console.WriteLine();
