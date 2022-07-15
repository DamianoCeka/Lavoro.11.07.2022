using System.Collections.Generic;

namespace Lavoro._11._07._2022
{
    public abstract class IntermediarioFinanziario 
    {
        protected List<Account> accounts;
        public IntermediarioFinanziario()
        {
         accounts = new List<Account>();
        }
    }  
}
