

namespace Exemplos
{
    public class Pessoa : Animal
    {
        public string Nome;
        public int Idade;

        public override void FazerSom()
        {
            Console.WriteLine($"OLA");
            
        }

        public override void mover()
        {
            Console.WriteLine($"te tec tec");
            
        }

        public void Dormir()
        {
            Console.WriteLine($"zzzzz");
            
        }
    }
}