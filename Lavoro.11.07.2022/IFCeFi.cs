using Lavoro._11._07._2022.Interfacce;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lavoro._11._07._2022
{
    public abstract class IFCeFi : IntermediarioFinanziario, ICefi
    {
       protected List<Client> clients;
        
        public IFCeFi()
        {
            this.clients = new List<Client>();
            
        }
        protected Client GetClient(Person person)
        {
            Client client = this.clients.Where(p => p.Cf == person.Cf).FirstOrDefault();             
            return client;
        }

        public abstract string CheckAccount(Person person);
        public abstract void CloseAccount();
        public abstract void Deposit(Person person, decimal Amount);
        public abstract string Kyc();
        public abstract void OpenAccount(Person person);
        public abstract decimal TransactCrypto();
        public abstract decimal TransactFiat();
        public abstract void Withdraw(Person person, decimal Amount);    
    }
    public class Broker : IFCeFi
    {
        public override string CheckAccount(Person person)
        {
            throw new NotImplementedException();
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override void Deposit(Person person, decimal Amount)
        {
            throw new NotImplementedException();
        }

        public override string Kyc()
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

        public override decimal TransactFiat()
        {
            throw new NotImplementedException();
        }
        

        public override void Withdraw(Person person, decimal Amount)
        
        {
            throw new NotImplementedException();
        }
    }
    public class CeEx : IFCeFi, InternationaService
    {
        public override string CheckAccount(Person person)
        {
            throw new NotImplementedException();
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override void Deposit(Person person, decimal Amount)
        {
            throw new NotImplementedException();
        }

        public override string Kyc()
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

        public override decimal TransactFiat()
        {
            throw new NotImplementedException();
        }

       
        public override void Withdraw(Person person, decimal Amount)
        {
            throw new NotImplementedException();
        }

        string InternationaService.InternaTionalWithdraw()
        {
            throw null;
        }

    }
    public class CeExCredit : IFCeFi, CreditSevice
    {
        public override string CheckAccount(Person person)
        {
            throw new NotImplementedException();
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override void Deposit(Person person, decimal Amount)
        {
            throw new NotImplementedException();
        }

        public override string Kyc()
        {
            throw new NotImplementedException();
        }

        public int Loans()
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

        public override decimal TransactFiat()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(Person person, decimal Amount)
        {
            throw new NotImplementedException();
        }
    }
    public class CeExPrestiti : IFCeFi
    {
        public override string CheckAccount(Person person)
        {
            throw new NotImplementedException();
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

       
        public override void Deposit(Person person, decimal Amount)
        {
            throw new NotImplementedException();
        }
        public override string Kyc()
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

        public override decimal TransactFiat()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(Person person, decimal Amount)
        {
            throw new NotImplementedException();
        }
    }  
    //public class BancoDeiPegni : ICefi
    //{
        

    //    public void CloseAccount()
    //    {
    //        throw null;
    //    }

    //    public decimal Deposti()
    //    {
    //        throw null;
    //    }

    //    public string Kyc()
    //    {
    //        throw null;
    //    }

       

    //    public decimal TransactCrypto()
    //    {
    //        throw null;
    //    }

    //    public decimal TransactFiat()
    //    {
    //        throw null;
    //    }

    //    public int Withdraw()
    //    {
    //        throw null;
    //    }

    //    string CheckAccount(Person person)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    string OpenAccount(Person person)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
