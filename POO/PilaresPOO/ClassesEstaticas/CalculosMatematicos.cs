

namespace Classesestaticas
{
    public class CalculosMatematicos
    {
        public static double PI = 3.14159265359;
        public static float Somar(float x, float y)
        {
            return x + y;
        }
     
        public static float Substrair(float x, float y)
        {
            return x - y;
        }
  
        public static float Multiplicar(float x, float y)
        {
            return x * y;
        }

        public static float Dividir(float x, float y)
        {
            if(y == 0)
            Console.WriteLine($"Divisao Invalida");
            
            return x / y;
        }
    }
}
