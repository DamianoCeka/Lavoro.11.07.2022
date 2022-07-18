using Lavoro._11._07._2022.Interfacce;
using Lavoro._11._07._2022.Models;
using System;
using System.Collections.Generic;

namespace Lavoro._11._07._2022
{
    public abstract class Broker : IFCeFi
    {
        public class RealBroker : Broker, IStockService
        {
            class BorkerAccount : Account
            {
                decimal _Saldo;
                public decimal Saldo { get { return _Saldo; } set { _Saldo = value; } }
                public BorkerAccount(string accountNumber) : base(accountNumber)
                {
                    this._products = new List<Product>();
                }
                public override void Deposit(Person person, decimal amount)
                {
                    _Saldo += amount;
                }
                public override void Withdraw(Person person, decimal amount)
                {
                    _Saldo -= amount;
                }
                public override void GetAccount(Person person) { }
                public override void GetSaldo(Person person) { }
            }




            public override CheckAccountResponse CheckAccount(Person person)
            {

                return new CheckAccountResponse();  
            }

            public override void CloseAccount(Person person, int AccountNumebr)
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

            public void Withdraw(Person person, decimal Amount, TickerStock tickerStock)
            {
                throw new NotImplementedException();
            }
            public void Deposit(Person person, decimal Amount, TickerStock tickerStock)
            {
                throw new NotImplementedException();
            }


        }
    }
}
