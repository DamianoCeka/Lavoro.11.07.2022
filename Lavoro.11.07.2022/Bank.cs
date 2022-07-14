using Lavoro._11._07._2022.Interfacce;
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
    public class LocalBanck : Bank
    {

        class BankAccount : Account
        {
            public BankAccount(string accountNumber) : base(accountNumber)
            {

            }
        }
        public override string CheckAccount(Person person)
        {
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

        public override decimal Deposti()
        {
            throw new NotImplementedException();
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

        public override int Withdraw()
        {
            throw new NotImplementedException();
        }
    }
    public class InternationalBank : Bank, InternationaService
    {
        public override string CheckAccount(Person person)
        {
            throw new NotImplementedException();
        }

        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override decimal Deposti()
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

        public override int Withdraw()
        {
            throw new NotImplementedException();
        }
    }
}
