using System;

namespace Lavoro._11._07._2022
{
    public abstract class Product 
    {
        public Account<Cash> _account;
        public int _id;
        public Product(Account<Cash> Account)
        {
            _id = new Random().Next(10000, 100000);
            _account = Account;
        }
       
    } // questa
    public class Cash : Product
    {
        public decimal _amount;
        TickerCash tickerCash;
        public Cash(Account<Cash> Account,decimal Amount, TickerCash TickerCash) :base(Account)
        {
            _amount = Amount;
            tickerCash = TickerCash;
        }
        public enum TickerCash
        {
            EURO,
            USD,
            GBP,
        } 
       
    }
    public class Cryto : Product
    {
        decimal _amount;
        public Cryto(Account<Cash> Account, decimal Amount, TickerCrypto TickerCrypto) : base(Account)
        {

        }
        public enum TickerCrypto
        {
            BTC,
            ETH,
            BNB,
        }
    }
    public class Stock : Product
    {
        int _amount;
        public Stock(Account<Cash> Account, decimal Amount, TickerStock TickerStock) : base(Account)
        {

        }
        public enum TickerStock
        {
            TESLA,
            AMAZON,
            COCACOLA,
        }
    }
}

