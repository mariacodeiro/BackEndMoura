
int salario, salarioNovo;
string cargo;

Console.WriteLine($"digite o cargo do fumcionario producao, administrativo ou diretoria");
cargo = Console.ReadLine();

Console.WriteLine($"digite o salario do funcionario");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao")
{
    salarioNovo = salario + (salario * 0.065f);
}

else if (cargo == "administrativo")
{
    salarioNovo == salario + (salario * 0.075);
}

else if (cargo == "diretiria")
{
    salarioNovo == salario + (salario * 0*012f)
}


