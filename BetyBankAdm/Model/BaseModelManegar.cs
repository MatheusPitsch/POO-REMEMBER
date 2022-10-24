using BetyBankAdm.SystemInternal;

namespace BetyBankAdm.Model
{
    public abstract class BaseModelManegar : BaseModel , IAuthentic
    {
        public string Password { get; set; }
        public BaseModelManegar(string password,string name, string cpf, decimal wage) : base(name, cpf, wage)
        {
            this.Password = password;
        }        

        public override decimal GetBonus()
        {
            throw new NotImplementedException();
        }

        public override void IncreaseSalary()
        {
            throw new NotImplementedException();
        }       

        public bool Authenticate(string password)
        {
            if (this.Password==password)
            {
                Console.WriteLine("Bem Vindo");
                return true;
            }
            Console.WriteLine("Senha Incorreta");
            return false;
        }        
    }
}