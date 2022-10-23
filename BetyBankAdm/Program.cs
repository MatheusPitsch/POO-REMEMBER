using BetyBankAdm.Funcionarios;
using bytebank_ADM.Utilitario;
using System.Reflection.Metadata;

Funcionario pedro = new Funcionario();

pedro.Name = "Pedro";
pedro.Cpf = "10590430920";
pedro.Wage = 100.0M;

Diretor Carla = new Diretor();

Carla.Name = "Pedro";
Carla.Cpf = "10590430920";
Carla.Wage = 100.0M;

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.Registrar(Carla);
gerenciador.Registrar(pedro);

Console.WriteLine("Total de bonificações: " + gerenciador.GetBonificacao());


Console.ReadLine();