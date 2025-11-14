
namespace Heranca
{
    public class Moto : Veiculo
    {
        public int velocidadeMax;

        public void somMoto()
        {
            Console.WriteLine($"Vrummmm.......vrummmmmm");
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Velocidade Máxima: {velocidadeMax}");
            Console.WriteLine();
        }

        public void Acelerar()
        {
            Console.WriteLine($"Tutuututututu....");
            
        }

    }
}






