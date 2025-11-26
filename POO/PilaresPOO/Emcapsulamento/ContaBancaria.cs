

namespace Emcapsulamento
{
    public class ContaBancaria
    {
        private float Saldo; 


        public ContaBancaria()
        {
            Saldo = 0;
        }
public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
            {
                Saldo = 0;
            }
        }



        public void Depositar(float valor)
        {
            if(valor >=0)
            {
                Console.WriteLine($"valor invalido");
                
            }
            else
            {
                Saldo = valor;
            }
            
        }
        public float GetSaldo()
        {
          return  Saldo;
        }



        public void Sacar(float valor)
        {  
            if (valor <= 0 && valor >= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"so pode sacar valores positivos");
                
            }
            else
            {
                 Saldo -= valor;
            }
           
        }
    }
}