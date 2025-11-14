
class Funcionario
{
    public string Nome ;
    public double SalarioBase ;

    public Funcionario(string nome, double salarioBase)
    {
        Nome = nome;
        SalarioBase = salarioBase;
    }

    public virtual double CalcularSalario()
    {
        return SalarioBase;
    }
}

