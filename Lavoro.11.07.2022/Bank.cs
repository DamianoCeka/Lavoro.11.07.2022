using Lavoro._11._07._2022.Interfacce;
using System;
using System.Collections.Generic;

namespace Lavoro._11._07._2022
{
    public abstract class Bank : IFCeFi, PaymentService, CreditSevice 
    {


        public virtual string EmmitCard()
        {
            return "sono su bank";
        }

        public int Loans()
        {
            throw new NotImplementedException();
        }

        public decimal StorePayments()
        {
            throw new NotImplementedException();
        }

    }
    public class Cliente
    {
        public Cliente(string Name , string cF)
        {
            _name = Name;
            _cf = cF;
        }
        string _name;
        string _cf;
    }
    public class LocalBanck : Bank
    {

        class BankAccount : Account
        {
            
        }
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


        public override void OpenAccount(Person Person)
        {
            
            Client Client = new Client(Person.Cf);
            this.clients.Add(Client);


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
    public class InternationalBank : Bank, InternationaService
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

        public string InternaTionalWithdraw()
        {
            return " stai prelevando dal estero ";
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
}
