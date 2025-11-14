using System;

class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
    }
}

class Carro : Veiculo
{
    public int NumeroPortas { get; set; }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Carro - Marca: {Marca}, Modelo: {Modelo}, Portas: {NumeroPortas}");
    }
}

class Moto : Veiculo
{
    public string TipoCapacete { get; set; }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Moto - Marca: {Marca}, Modelo: {Modelo}, Capacete: {TipoCapacete}");
    }
}
