﻿using Lavoro._11._07._2022.Interfacce;
using Lavoro._11._07._2022.Models;
using Lavoro._11._07._2022.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lavoro._11._07._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Abreham = new Person("f23tiqwe");
            LocalBank Hype = new LocalBank();
         //   Broker ing = new BrokerAccount();
            
         //   ing.TransactCrypto = true;

         // List<Broker> list = new List<Broker>();
         //  list.Add(ing);

         //  List<Broker> b = list.Where(b => b.TransactCrypto == true && b.TransactFiat == true).ToList() ;


         //  ing.Withdraw(Abreham,2,TickerStock.TESLA); 

            Hype.OpenAccount(Abreham);
            CheckAccountResponse res =  Hype.CheckAccount(Abreham); // --> il Saldo
              
            if(res != null)
            {
                Hype.CloseAccount(Abreham, res.AccountNumber);
            } 




            //list {
            //    new Account("51515155"), ->> Costruttore
            //    new Account("611494494"),
            //    new Account("58111818")
            //}


            //   Hype.Deposit(Abreham, 1000M,TickerCash.USD);
            ////   ing.Deposit(Abreham, 2, TickerStock.COCACOLA);
            //   Hype.Withdraw(Abreham,500M , TickerCash.EURO);
            //   Hype.Withdraw(Abreham,800M , TickerCash.USD);

        }
    }
}
