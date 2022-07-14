using Lavoro._11._07._2022.Interfacce;
using System;

namespace Lavoro._11._07._2022
{
    public abstract class IFDefi : IntermediarioFinanziario , Idefi
    {
        public abstract string CheckAccount(Person person);


        public abstract void CloseAccount();

        public abstract void Deposit(Person person, decimal Amount);
            

        public abstract void OpenAccount(Person person);
      
        public abstract decimal TransactCrypto(); // in questo caso dobbiamo far ereditare a dex un contratto da un interfaccia


        public abstract void Withdraw(Person person, decimal Amounts);
        
    }
    public class DeEx : IFDefi, CreditSevice
    {
        public override string CheckAccount(Person person)
        {
            throw new NotImplementedException();
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override void Deposit(Person person, decimal Amounts)
        {
            throw new NotImplementedException();
        }

        public override void OpenAccount(Person person)
        {
            throw new NotImplementedException();
        }

        public override decimal TransactCrypto()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(Person person, decimal Amounts)
        {
            throw new NotImplementedException();
        }

        int CreditSevice.Loans()
        {
            throw null;
        }
    }
    public class NoCustoDialWallet : IFDefi
    {
        public override string CheckAccount(Person person)
        {
            throw new NotImplementedException();
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override void Deposit(Person person, decimal Amounts)
        {
            throw new NotImplementedException();
        }

        public override void OpenAccount(Person person)
        {
            throw new NotImplementedException();
        }

        public override decimal TransactCrypto()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(Person person, decimal Amounts)
        {
            throw new NotImplementedException();
        }
    }
}
