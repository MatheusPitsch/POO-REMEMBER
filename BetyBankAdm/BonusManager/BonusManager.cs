using BetyBankAdm.Model;

namespace BetyBankAdm.Utilitario
{
    public class BonusManager
    {
        private decimal totalBonus;

        public void Register(BaseModel employee)
        {
            this.totalBonus += employee.GetBonus();
        }                      

        public decimal GetTotalBonus()
        {
            return this.totalBonus;
        }
    }
}