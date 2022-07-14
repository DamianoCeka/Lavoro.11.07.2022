﻿using Lavoro._11._07._2022.Interfacce;
using System;
using System.Collections.Generic;
using System.Linq;

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
    public class LocalBank : Bank
    {
       
        public LocalBank()
        {
           
        }
        class BankAccount : Account<Cash>
        {
            decimal _Saldo; 
            public decimal Saldo { get { return _Saldo; } set { _Saldo = value; } }     
            public BankAccount(string accountNumber) : base(accountNumber)
            {
                this._products = new List<Cash>(); 
            } 
            public void DepositSaldo(decimal amount)
            {
                _Saldo += amount; 
            }
            public void WithDrawSaldo(decimal amount)
            {
                _Saldo -= amount;
            }
        }
         private string GetAccount(Person person)
        {  


            /// Controllare se il cliente esiste nella lista
            Client client = GetClient(person);
            if (client != null)
            {
                return client._accountNumber;
            }

            return "Nessun conto trovato per questo cliente"; 
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override void Deposit(Person person, decimal amount)
        {
            string accountNumber = GetAccount(person);            
            
            if (!string.IsNullOrEmpty(accountNumber))
            {
                Account<Cash> account = this.accounts.Where(a => a._accountNumber == accountNumber).FirstOrDefault();
                BankAccount Baccount = (BankAccount) account; 
                if (Baccount != null)
                {
                    Baccount._products.Add(new Cash(Baccount, 1000M, Cash.TickerCash.USD));
                    Baccount.DepositSaldo(amount);
                    //Baccount._products.Add(new Cryto(Baccount, 2, Cryto.TickerCrypto.BTC));
                    //Baccount._products.Add(new Stock(Baccount, 2, Stock.TickerStock.TESLA));
                }
            } 
        }
        
        public override string Kyc()
        {
            throw new NotImplementedException();
        }
            

        public override void OpenAccount(Person Person)
        {
            // Cercare se il cliente esiste nella lista dei clienti
            Client client = GetClient(Person);
            if(client == null)
            {
                client = new Client(Person.Cf); // Creao un nuovo cleinte partendo dalla persona 
                clients.Add(client); /// metto il nuovo cliente dentro la lista dei clienti della banca.
            }
            Random r = new Random();  // Creo un numero random da dare al nuovo  BankAccount
            int number = r.Next(10000,100000);

            //Creo il nuovo bankAccount, passo il numero random creato al contruttore del BankAccount
            BankAccount  newAccount = new BankAccount(number.ToString());

            //associo il cliente al nuovo conto che ho creato
            newAccount._client = client;

            //associo il accountNumber al cliente. 
            client._accountNumber = newAccount._accountNumber;

            // aggiungo il nuovo conto creato alla lista dei coti della banca
            this.accounts.Add(newAccount); 



        }

        public override decimal TransactCrypto()
        {
            throw new NotImplementedException();
        }

        public override decimal TransactFiat()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw(Person Person, decimal Amount)
        {
            Client currentClient= GetClient(Person);     
            if(currentClient == null)  
                return ;
            else
            {
                Account<Cash> account = GetAccount(currentClient._accountNumber);  
                if(account!= null)
                {
                  
                   BankAccount baccount = account as BankAccount; // ->> l'errore è gestito del framework 
                     
                   if(baccount.Saldo >= Amount) 
                    {
                        baccount.WithDrawSaldo(Amount);
                        Console.WriteLine($"Prelievo di {Amount}  effettuato con successo!");

                    }
                    else
                    {
                        Console.WriteLine($"Vuoi prelevare {Amount} ma hai SOLO {baccount.Saldo} ");
                        Console.WriteLine("Sei povero!");
                    }

                   
                }
            }
        }
        public override string CheckAccount(Person person)
        {   
            
            string accountNumber =  GetAccount(person); 

            if(!string.IsNullOrEmpty(accountNumber))
            {
                Account<Cash> Baccount = this.accounts.Where(a=> a._accountNumber == accountNumber).FirstOrDefault();  

                if(Baccount!= null)
                {
                   //  Restitutuire il saldo del conto Corrente! 
                }
            }
            return string.Empty;
        }

        private Account<Cash> GetAccount(string AccountNumber)
        {
          return  this.accounts.Where((a) =>a._accountNumber == AccountNumber).FirstOrDefault();   
        }

    }
    public class InternationalBank : Bank, InternationaService
    {
        public override string CheckAccount(Person person)
        {
            return string.Empty;
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override void Deposit(Person person,decimal amount)
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

        public override void Withdraw(Person person, decimal amount)
        {
            
        }
    }
}
