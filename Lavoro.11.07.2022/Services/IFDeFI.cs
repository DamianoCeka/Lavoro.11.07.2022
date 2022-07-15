using Lavoro._11._07._2022.Interfacce;

namespace Lavoro._11._07._2022
{
    public abstract class IFDeFI : IntermediarioFinanziario , IDeFI
    {
        public abstract string CheckAccount(Person person);
        public abstract void CloseAccount();
        public abstract void Deposit(Person person, decimal Amount);  
        public abstract void OpenAccount(Person person);      
        public abstract decimal TransactCrypto(); 
        public abstract void Withdraw(Person person, decimal Amounts);
        
    }
}
