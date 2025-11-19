

namespace Exemplos
{
    public class ControleRemoto : IControle
    {

public int NivelVolume = 0;
public int VolumeMaximo = 30;

        public void AumentarVolume()
        {
           if(NivelVolume == VolumeMaximo)
           {
                Console.WriteLine($"volume maximo atingido {NivelVolume}");
                return;
                
           }
            NivelVolume++;
           Console.WriteLine($"Volume: {NivelVolume}");
           
        }

        public void desligar()
        {
            Console.WriteLine($"Desligando a TV...");
            
        }

        public void DiminuirVolume()
        {
           if (NivelVolume == 0)
           {
                Console.WriteLine($"volume ja esta no minimo");
                return;
            }
         Console.WriteLine($"Volume: {NivelVolume}");
         
        }

        public void ligar()
        {
            Console.WriteLine($"Ligando a tv");
            
        }
    }
}