
namespace Exemplos
{
    public class Carro : IMotor
    {

        public string cor;
        public string Marca;
        public string Modelo;
        public int Ano;


        //construtores
        public Carro(string c, string m, string Md, int a)
        {
            cor = c;
            Marca = m;
            Modelo = Md;
            Ano = a;
        }

        //metodos

        public void ExibirInfo()
        {
            Console.WriteLine($@"
            Marca: {Marca}
            Marca: {Modelo}
            Marca: {Ano}
            Marca: {cor}
            
            
            Informacoes do veiculo:");
            
        }


        public void Acelerar()
        {
           Console.WriteLine($"Carro acelerando.... Vrum Vrum");
           
        }

        public void Freiar()
        {
            Console.WriteLine($"Carro Freiando... irrrrrr");
            
        }
    }
}