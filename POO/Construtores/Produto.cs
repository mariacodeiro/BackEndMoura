

namespace Construtores
{
    public class Produto
    {
        public string Nome;
        public float preco;
        public int estoque;

        public Produto(string n, float p, int e)
        {
            Nome = n;
            preco = p;
            estoque = e;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Nome}, preco: {preco}, quantidade em estoque: {estoque}");
        }
    }
}