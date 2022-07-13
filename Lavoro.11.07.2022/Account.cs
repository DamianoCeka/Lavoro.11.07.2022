using System.Collections.Generic;

namespace Lavoro._11._07._2022
{
    public abstract class Account 
    {
        protected string _accountNumber;
        protected List<Product> _products;

        public Account()
        {
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
        public Client(string cf) : base(cf)
        {
            
        }
    }
   
    public class BankAccount : Account
    {
        public BankAccount(List<Product> products) 
        {

        }
    }
    public class CryptoWallet : Account
    {
        public CryptoWallet(List<Product> products)
        {

        }
    }

    public class StckAccount : Account
    {
        public StckAccount(List<Product> products) 
        {

        }
    }
}
