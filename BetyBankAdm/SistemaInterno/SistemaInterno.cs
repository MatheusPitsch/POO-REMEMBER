using BetyBankAdm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetyBankAdm.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Singin(Atentica funcionario, string password)
        {
            bool userAuthentic = funcionario.Authentic(password);
            
            if (userAuthentic)
            {
                Console.WriteLine("Bem vindo");
                return true;
            }
            Console.WriteLine("Senha invalido");
            return false;
        }        
    }
}