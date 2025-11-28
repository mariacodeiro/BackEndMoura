using Emcapsulamento;

string Encapsulamento;

// ContaBancaria contaEdu = new ContaBancaria();
// ContaBancaria contaMadu = new ContaBancaria();


// contaEdu.Depositar(-100);
// contaEdu.Depositar(20);
// contaMadu.Sacar(-100);
// contaMadu.Sacar(300);

// Console.WriteLine();

// Console.WriteLine($"Saldo atual do edu: R${contaEdu.GetSaldo}");
// Console.WriteLine($"Saldo atual da maria: R${contaMadu.GetSaldo}");


    static void Main(string[] args)
    {
        Carro meuCarro = new Carro();

        // Definindo marca e modelo
        meuCarro.DefinirMarca("Toyota");
        meuCarro.DefinirModelo("Corolla");

        // Ações no carro
        meuCarro.Acelerar(30);
        meuCarro.Acelerar(20);
        meuCarro.Frear(10);
        meuCarro.Frear(50); // não pode ficar abaixo de zero

        // Exibindo dados
        Console.WriteLine("Marca: " + meuCarro.ObterMarca());
        Console.WriteLine("Modelo: " + meuCarro.ObterModelo());
        Console.WriteLine("Velocidade Atual: " + meuCarro.ObterVelocidade() + " km/h");
    }

