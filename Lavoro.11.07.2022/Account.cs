using System.Collections.Generic;

namespace Lavoro._11._07._2022
{
    public abstract class Account<T> where T : Product
    {
        public string _accountNumber;
        public List<T> _products;        
        public Client _client;
      //  public decimal Saldo { get { } }; 

        public Account(string accountNumber)
        {
            _accountNumber = accountNumber;
           // _products = new List<T>();  
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
