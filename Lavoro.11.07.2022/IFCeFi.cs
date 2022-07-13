using Lavoro._11._07._2022.Interfacce;
using System;
using System.Collections.Generic;

namespace Lavoro._11._07._2022
{
    public abstract class IFCeFi : IntermediarioFinanziario, ICefi
    {
       protected List<Client> clients;
        
        public IFCeFi()
        {
            this.clients = new List<Client>();
            
        }

        public abstract decimal CheckAccount();
        public abstract void CloseAccount();
        public abstract decimal Deposti();
        public abstract string Kyc();
        public abstract void OpenAccount(Person person);
        public abstract decimal TransactCrypto();
        public abstract decimal TransactFiat();
        public abstract int Withdraw();    
    }
    public class Broker : IFCeFi
    {
        public override decimal CheckAccount()
        {
            throw new NotImplementedException();
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override decimal Deposti()
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

        public override int Withdraw()
        {
            throw new NotImplementedException();
        }
    }
    public class CeEx : IFCeFi, InternationaService
    {
        public override decimal CheckAccount()
        {
            throw new NotImplementedException();
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override decimal Deposti()
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

        public override int Withdraw()
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
        public override decimal CheckAccount()
        {
            throw new NotImplementedException();
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override decimal Deposti()
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

        public override int Withdraw()
        {
            throw new NotImplementedException();
        }
    }
    public class CeExPrestiti : IFCeFi
    {
        public override decimal CheckAccount()
        {
            throw new NotImplementedException();
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override decimal Deposti()
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

        public override int Withdraw()
        {
            throw new NotImplementedException();
        }
    }  
    public class BancoDeiPegni : ICefi
    {
        public decimal CheckAccount()
        {
            throw null;
        }

        public void CloseAccount()
        {
            throw null;
        }

        public decimal Deposti()
        {
            throw null;
        }

        public string Kyc()
        {
            throw null;
        }

        public void OpenAccount(Person person)
        {
            throw null;
        }

        public decimal TransactCrypto()
        {
            throw null;
        }

        public decimal TransactFiat()
        {
            throw null;
        }

        public int Withdraw()
        {
            throw null;
        }
    }
}
