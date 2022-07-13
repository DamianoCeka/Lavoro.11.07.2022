﻿using Lavoro._11._07._2022.Interfacce;
using System;

namespace Lavoro._11._07._2022
{
    public abstract class IFDefi : IntermediarioFinanziario , Idefi
    {
        public abstract decimal CheckAccount();


        public abstract void CloseAccount();


        public abstract decimal Deposti();

        public abstract string OpenAccount();
      
        public abstract decimal TransactCrypto(); // in questo caso dobbiamo far ereditare a dex un contratto da un interfaccia


        public abstract int Withdraw();
        
    }
    public class DeEx : IFDefi, CreditSevice
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

        public override string OpenAccount()
        {
            throw new NotImplementedException();
        }

        public override decimal TransactCrypto()
        {
            throw new NotImplementedException();
        }

        public override int Withdraw()
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

        public override string OpenAccount()
        {
            throw new NotImplementedException();
        }

        public override decimal TransactCrypto()
        {
            throw new NotImplementedException();
        }

        public override int Withdraw()
        {
            throw new NotImplementedException();
        }
    }
}
