using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"au au");
            
        }

        public override void mover()
        {
            Console.WriteLine($"tec tec tec");
            
        }
    }
}