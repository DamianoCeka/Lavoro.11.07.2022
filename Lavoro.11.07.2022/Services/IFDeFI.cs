using Lavoro._11._07._2022.Interfacce;
using Lavoro._11._07._2022.Models;

namespace Lavoro._11._07._2022
{
    public abstract class IFDeFI : IntermediarioFinanziario , IDeFI
    {
        public abstract CheckAccountResponse CheckAccount(Person person);
        public abstract void CloseAccount(Person person, int AccountNumber);

        public abstract void Deposit(Person person, decimal Amount);  
        public abstract void OpenAccount(Person person);      
        public abstract decimal TransactCrypto(); 
        public abstract void Withdraw(Person person, decimal Amounts);
        
    }
}
