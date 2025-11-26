

namespace Exercicio02
{
    public class Contrato : Imprimivel
    {
public string nome;
public string textoClausulas;
    public void Imprimir()
    {
       Console.WriteLine($@"
       contratante {nome}
       clausulas: {textoClausulas}
       ");
       
        
    }
}
  }