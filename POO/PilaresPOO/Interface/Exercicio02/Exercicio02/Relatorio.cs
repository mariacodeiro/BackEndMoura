
namespace Exercicio02
{
    public class Relatorio  : Imprimivel
    { public string NomeResponsavel;
    public string TextoRelatorio;
        internal void Imprimir()
        {
           Console.WriteLine($@"
           responsavel: {NomeResponsavel}
           relatorio: {TextoRelatorio}
           ");

            
        }
    }
}