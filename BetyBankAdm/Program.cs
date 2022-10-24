using BetyBankAdm.Funcionarios;

public class Program
{
    private static void Main(string[] args)
    {
        {
            //Funcionario pedro = new Funcionario("10590430920", 100.0M);
            //pedro.Name = "Pedro";

            //Diretor Carla = new Diretor("10590430920", 100.0M);
            //Carla.Name = "Pedro";

            //GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

            //gerenciador.Registrar(Carla);
            //gerenciador.Registrar(pedro);

            //Console.WriteLine("Total de bonificações: " + gerenciador.GetBonificacao());

            //Console.WriteLine(Funcionario.ContadorFuncionario);

            //Console.WriteLine(pedro.Wage);
            //Console.WriteLine(Carla.Wage);

            //pedro.AumentaSalario();
            //Carla.AumentaSalario();

            //Console.WriteLine(pedro.Wage);
            //Console.WriteLine(Carla.Wage);
        }

        {
            CalcularBonificacao();

            void CalcularBonificacao()
            {
                //GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

                //Designer ulisses = new Designer("123456");
                //ulisses.Name = "Ulisses Souza";

                //Diretor paula = new Diretor("987456");
                //paula.Name = "Paula Souza";

                //Auxiliar igor = new Auxiliar("74581");
                //igor.Name = "Igor Dias";

                //GerenteDeConta camila = new GerenteDeConta("852963");
                //camila.Name = "Camila Oliveira";

                //gerenciador.Registrar(camila);
                //gerenciador.Registrar(igor);
                //gerenciador.Registrar(paula);
                //gerenciador.Registrar(ulisses);

                //Console.WriteLine("Total de Bonificação = " + gerenciador.GetBonificacao());
            }

            UsarSistema();

            void UsarSistema()
            {
                //SistemaInterno sistema = new SistemaInterno();

                //Diretor ingrid = new Diretor("4685");
                //ingrid.Name = "Ingrid";
                //ingrid.password = "123";

                //GerenteDeConta carlos = new GerenteDeConta("145656");
                //carlos.Name = "Carlos";
                //carlos.password = "5875";

                //sistema.Singin(ingrid, "123");
                //sistema.Singin(carlos, "555");
            }
        }

        //Após refatoração

        {
            Director pedro = new Director("123","Pedro","15614");
            Console.WriteLine(pedro.ToString());
            pedro.Authenticate("321");
        }


        Console.ReadLine();
    }
}

