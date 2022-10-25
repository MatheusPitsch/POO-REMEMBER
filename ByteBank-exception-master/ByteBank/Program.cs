using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    ContaCorrente conta01 = new ContaCorrente(1, 1);
                    conta01.Sacar(100);

                }
                catch (excecaoException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Saldo insuficiente");
                }
                catch (ArgumentException rp)
                {
                    Console.WriteLine("Ocorreu um erro no argumento: " + rp.ParamName);
                    Console.WriteLine("Aconteceu um erro");
                    Console.WriteLine(rp.Message);
                }
            }

            //Trabalhando com exeção
            {
                //try
                //{
                //ChamarDivisor(10);
                //}
                //catch (DivideByZeroException)
                //{
                //    Console.WriteLine("Impossivel Fazer Divisão por 0");
                //}
            }



            Console.ReadLine();
        }
        public static int ChamarDivisor(int valor)
        {
            int A = 0;
            int B = valor;

            int divisao = B / A;

            return divisao;
        }
    }
}
