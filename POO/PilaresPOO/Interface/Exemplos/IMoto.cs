

namespace Exemplos
{
    public class IMoto
    {
        public string cor;
        public string Marca;
        public string Modelo;
        public int Ano;

         public IMoto(string c, string m, string md, int a)
        {
            cor = c;
            Marca = m;
            Modelo = md;
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
           Console.WriteLine($"moto acelerando.... Vrum Vrum");
           
        }

        public void Freiar()
        {
            Console.WriteLine($"moto Freiando... irrrrrr");
            
        }
    }
}
    
