
// class Program
// {
//     static void Main(string[] args)
//     {
//         Funcionario funcionario = new Funcionario("João", 300);
//         Gerente gerente = new Gerente("Maria", 5000, 200);

//         Console.WriteLine($"Funcionário: {funcionario.Nome}, Salário: {funcionario.CalcularSalario():C}");
//         Console.WriteLine($"Gerente: {gerente.Nome}, Salário: {gerente.CalcularSalario():C}");
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         Carro carro = new Carro();
//         carro.Marca = "Porche";
//         carro.Modelo = "hatch";
//         carro.NumeroPortas = 4;

//         Moto moto = new Moto();
//         moto.Marca = "Honda";
//         moto.Modelo = "CG 160";
//         moto.TipoCapacete = "Fechado";

//         carro.MostrarInfo();
//         moto.MostrarInfo();

//         Console.ReadLine();
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno
        {
            Nome = "Maria. C",
            Idade = 20,
            Curso = "ADM"
        };

        Professor professor = new Professor
        {
            Nome = "Mariana",
            Idade = 35,
            Disciplina = "historia
        "
        };

        aluno.MostrarInfo();
        professor.MostrarInfo();

        Console.ReadLine();
    }
}