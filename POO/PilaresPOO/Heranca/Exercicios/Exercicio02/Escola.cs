using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}

class Aluno : Pessoa
{
    public string Curso { get; set; }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Aluno: {Nome}, Idade: {Idade}, Curso: {Curso}");
    }
}

class Professor : Pessoa
{
    public string Disciplina { get; set; }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Professor: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}");
    }
}