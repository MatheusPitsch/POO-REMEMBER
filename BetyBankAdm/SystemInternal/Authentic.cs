using BetyBankAdm.Model;
using System.ComponentModel;

namespace BetyBankAdm.SystemInternal
{
    public interface IAuthentic
    {
        public string Password { get; set; }       
        public bool Authenticate(string password);
    }
}
