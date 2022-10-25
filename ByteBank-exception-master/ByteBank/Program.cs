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
                ContaCorrente conta01 = new ContaCorrente(0,0);

                }
                catch (ArgumentException rp)
                {
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
