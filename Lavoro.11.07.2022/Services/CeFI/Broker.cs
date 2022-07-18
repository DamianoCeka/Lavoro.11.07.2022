using Lavoro._11._07._2022.Interfacce;
using System;

namespace Lavoro._11._07._2022
{
    public class Broker : IFCeFi, IStockService
    {
        public override string CheckAccount(Person person)
        {
            throw new NotImplementedException();
        }

        public override void CloseAccount(Person person, int AccountNumebr)
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
