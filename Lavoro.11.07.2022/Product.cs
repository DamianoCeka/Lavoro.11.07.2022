﻿using System;

namespace Lavoro._11._07._2022
{
    public abstract class Product 
    {
        public Account _account;
        public int _id;
        public Product(Account Account)
        {
            _id = new Random().Next(10000, 100000);
            _account = Account;
        }
    } 
    public partial class Cash : Product
    {
        public decimal _amount;
        TickerCash tickerCash;
        public Cash(Account Account,decimal Amount, TickerCash TickerCash) :base(Account)
        {
            _amount = Amount;
            tickerCash = TickerCash;
        }
       
    }
    public partial class Cryto : Product
    {
        public decimal _amount;
        TickerCrypto _tickerCash;

        public Cryto(Account Account, decimal Amount, TickerCrypto TickerCrypto) : base(Account)
        {
            _amount = Amount;
            _tickerCash = TickerCrypto; 
        }
    }
    public partial class Stock : Product
    {
        public int _amount;
        TickerStock _tickerStock;

        public Stock(Account Account, int Amount, TickerStock TickerStock) : base(Account)
        {
            _amount = Amount;
            _tickerStock = TickerStock;
        }
    }
}

