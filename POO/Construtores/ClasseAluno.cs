

namespace Construtores
{
    public class ClasseAluno
    {
        public string Nome;
        public int Nota;

        public ClasseAluno()
        {
            Console.WriteLine($"Lista de alunos");
        }

        public ClasseAluno(string n, int m)
        {
            Nome = n;
            Nota = m;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Aluno: {Nome} | Nota: {Nota}");
        }
       
    }
}