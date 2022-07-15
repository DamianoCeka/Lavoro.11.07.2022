using System.Collections.Generic;

namespace Lavoro._11._07._2022
{
    public abstract class Account
    {
        public string _accountNumber;
        public List<Product> _products;        
        public Client _client;  
        public Account(string accountNumber)
        {
            _accountNumber = accountNumber;
            _products = new List<Product>();  
        } 
        public abstract void GetAccount(Person person);
        public abstract void GetSaldo(Person person);
        public abstract void Withdraw(Person person, decimal amount);
        public abstract void Deposit(Person person, decimal amount);
    }   
}
