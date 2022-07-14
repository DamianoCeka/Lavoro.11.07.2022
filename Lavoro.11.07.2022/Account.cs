using System.Collections.Generic;

namespace Lavoro._11._07._2022
{
    public abstract class Account 
    {
        public string _accountNumber;
        protected List<Product> _products;
        public Client _client;

        public Account(string accountNumber)
        {
            _accountNumber = accountNumber;
            _products = new List<Product>();  
        } 
       
    }
    public class Person
    {
        public string Cf;

        public Person(string cf)
        {
            Cf = cf;
        }


    }
    public class Client : Person
    {
        public string _accountNumber;
        public Client(string cf) : base(cf)
        {
            
        }
    }
   
    
}
