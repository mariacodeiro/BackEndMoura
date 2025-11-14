
namespace Heranca
{
    public class Aviao : Veiculo
    {

        public int qntAssentos;
        public void Voar()
        {
            Console.WriteLine($"Avião Levantou vôo");
            Console.WriteLine($"Vooonnnn...voonnn");

        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Quantidade de Assentos: {qntAssentos}");
            Console.WriteLine();
        }
    }
}