using Lavoro._11._07._2022.Interfacce;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lavoro._11._07._2022
{
    public abstract class IFCeFi :
        IntermediarioFinanziario,
        ICeFI
    {
        protected List<Client> clients;
        
        public IFCeFi()
        {
            this.clients = new List<Client>();
            
        }
        protected Client GetClient(Person person)
        {
            Client client = this.clients.Where(p => p.Cf == person.Cf).FirstOrDefault();             
            return client;
        }

        public abstract string CheckAccount(Person person);
        public abstract void CloseAccount();
        public abstract void Deposit(Person person, decimal Amount);
        public abstract string Kyc();
        public abstract void OpenAccount(Person person);
        public abstract decimal TransactCrypto();
        public abstract decimal TransactFiat();
        public abstract void Withdraw(Person person, decimal Amount);    
    }
}
