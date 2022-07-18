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
        bool _transactFiat = false; 
         bool _transactCrypto = false;    
        public bool TransactFiat  { get { return _transactFiat; } set { _transactFiat = value; } } 
        public bool TransactCrypto { get { return _transactCrypto; } set { _transactFiat = value; } }
        
        public IFCeFi()
        {
            this.clients = new List<Client>();

        }
        protected Client GetClient(Person person)
        {
            Client client = this.clients.Where(p => p.Cf == person.Cf).FirstOrDefault();
            return client;
        }

        public abstract void OpenAccount(Person person);
        public abstract string CheckAccount(Person person);
        public abstract void CloseAccount(Person person , int AccountNumber);
        public abstract void Deposit(Person person, decimal Amount);
        public abstract string Kyc();
        
    }
}
