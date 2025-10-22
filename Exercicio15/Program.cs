//faca um programa que receba 4 notas de uma aluno, calcule e imprima a media aritimetica das notas
// e a mensagem de APROVADO para medias superior ou igual a 7 recuperacao para notas entre 5.0, ou 7.0 ou a mensagem de reprovado para media inferior a 5 

float n1, n2, n3, n4, media;


Console.WriteLine("digite a primeira nota");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("digite a segunda nota");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("digite a terceira nota");
n3 = float.Parse(Console.ReadLine());

Console.WriteLine("digite a quarta nota");
n4 = float.Parse(Console.ReadLine());

media = n1 + (n2 + n3 + n4) / 4;

Console.WriteLine("$media: {media}");

 if (media >= 7)
{
   Console.WriteLine("$aprovado");
}



