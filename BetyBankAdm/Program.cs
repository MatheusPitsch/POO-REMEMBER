using BetyBankAdm.Funcionarios;

Funcionario pedro = new Funcionario();

pedro.Name = "Pedro";
pedro.Cpf = "10590430920";
pedro.Wage = 100.0M;

Console.WriteLine(pedro.Wage);
Console.WriteLine(pedro.Bonus());


Console.ReadLine();