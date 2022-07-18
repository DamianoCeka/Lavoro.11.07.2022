using System.Collections.Generic;

namespace Lavoro._11._07._2022
{
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
        public string _accountNumber ; 
        public Client(string cf) : base(cf)
        {
          
                      

           
        }
    }

}
