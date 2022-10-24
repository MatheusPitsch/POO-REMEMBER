namespace BetyBankAdm.Model
{
    public abstract class BaseModel
    {
        public string Name { get; set; }
        public string Cpf { get; private set; }
        public decimal Wage { get; protected set; }
        public static int EmployeeAccountant { get; private set; }
        public BaseModel(string name ,string cpf, decimal wage)
        {
            this.Name = name;
            Wage = wage;
            Cpf = cpf;
            EmployeeAccountant++;
        }
        public abstract decimal GetBonus();
        public abstract void IncreaseSalary();
    }
}