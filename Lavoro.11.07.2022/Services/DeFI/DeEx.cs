﻿using Lavoro._11._07._2022.Interfacce;
using System;

namespace Lavoro._11._07._2022
{
    public class DeEx : IFDeFI, ICreditSevice
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

        int ICreditSevice.Loans()
        {
            throw null;
        }
    }
}
