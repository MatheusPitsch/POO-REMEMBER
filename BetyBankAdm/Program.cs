using BetyBankAdm.Funcionarios;
using bytebank_ADM.Utilitario;
using System.Reflection.Metadata;

Funcionario pedro = new Funcionario("10590430920");

pedro.Name = "Pedro";
pedro.Wage = 100.0M;

Diretor Carla = new Diretor("10590430920");

Carla.Name = "Pedro";
Carla.Wage = 100.0M;

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.Registrar(Carla);
gerenciador.Registrar(pedro);

Console.WriteLine("Total de bonificações: " + gerenciador.GetBonificacao());

Console.WriteLine(Funcionario.ContadorFuncionario);


Console.ReadLine();