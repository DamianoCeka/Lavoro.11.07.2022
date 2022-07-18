using Lavoro._11._07._2022.Interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavoro._11._07._2022.Services
{
    public abstract class Bank : IFCeFi, IPaymentService, ICreditSevice
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
    public class LocalBank : Bank, ICashService
    {

        public LocalBank()
        {

        }
        class BankAccount : Account
        {
            decimal _Saldo;
            public decimal Saldo { get { return _Saldo; } set { _Saldo = value; } }
            public BankAccount(string accountNumber) : base(accountNumber)
            {
                // this._products.Cast<Cash>().ToList(); 
                this._products = new List<Product>();
            }
            public override void Deposit(Person person, decimal amount)
            {
                _Saldo += amount;
            }
            public override void Withdraw(Person person, decimal amount)
            {
                _Saldo -= amount;
            }
            public override void GetAccount(Person person) { }
            public override void GetSaldo(Person person) { }
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



        public void Deposit(Person person, decimal amount, TickerCash tickerCash)
        {
            string accountNumber = GetAccount(person);

            if (!string.IsNullOrEmpty(accountNumber))
            {
                Account account = this.accounts.Where(a => a._accountNumber == accountNumber).FirstOrDefault();
                BankAccount Baccount = (BankAccount)account;
                if (Baccount != null)
                {
                    Baccount._products.Add(new Cash(Baccount, amount, tickerCash));
                    Baccount.Deposit(person, amount);
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
            if (client == null)
            {
                client = new Client(Person.Cf); // Creao un nuovo cleinte partendo dalla persona 
                clients.Add(client); /// metto il nuovo cliente dentro la lista dei clienti della banca.
            }
            Random r = new Random();  // Creo un numero random da dare al nuovo  BankAccount
            int number = r.Next(10000, 100000);

            //Creo il nuovo bankAccount, passo il numero random creato al contruttore del BankAccount
            BankAccount newAccount = new BankAccount(number.ToString());

            //associo il cliente al nuovo conto che ho creato
            newAccount._client = client;

            //associo il accountNumber al cliente. 
            client._accountNumber = newAccount._accountNumber;

            // aggiungo il nuovo conto creato alla lista dei coti della banca
            this.accounts.Add(newAccount);

        }
        public override void CloseAccount(Person person, int AccountNumber)
        {
            Client client = GetClient(person);
            if(client._accountNumber == client._accountNumber)
            {
                client.Cf.Remove(AccountNumber);
            }
            Console.WriteLine(" il tuo account e stato elimianto! ");
        }




        public override string CheckAccount(Person person)
        {
            BankAccount bankAccount = null;
            string accountNumber = GetAccount(person);

            if (!string.IsNullOrEmpty(accountNumber))
            {
                Account Baccount = this.accounts.Where(a => a._accountNumber == accountNumber).FirstOrDefault();

                if (Baccount != null)
                {
                    //  Restitutuire il saldo del conto Corrente! 
                }
            }
            return string.Empty;
        }

        private Account GetAccount(string AccountNumber)
        {
            return this.accounts.Where((a) => a._accountNumber == AccountNumber).FirstOrDefault();
        }

        
        

        public void Withdraw(Person person, decimal Amount, TickerCash TickerCash)
        {
            Client currentClient = GetClient(person);
            if (currentClient == null)
                return;
            else
            {
                Account account = GetAccount(currentClient._accountNumber);
                if (account != null)
                {

                    BankAccount baccount = account as BankAccount; // ->> l'errore è gestito del framework 

                    if (baccount.Saldo >= Amount)
                    {
                        baccount.Withdraw(person, Amount);
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
        public class InternationalBank : Bank, IInternationaService
        {
            public override string CheckAccount(Person person)
            {
                return string.Empty;
            }

            public override void CloseAccount(Person person, int AccountNumber)
            {
                throw new NotImplementedException();
            }

            public void Deposit(Person person, decimal Amount, TickerCash TickerCash)
            {
                throw new NotImplementedException();
            }

            public void IWithdraw(Person person, decimal Amount)
            {
                Console.WriteLine(" stai prelevando dal estero ");
            }
            public override string Kyc()
            {
                throw new NotImplementedException();
            }
            public override void OpenAccount(Person person)
            {
                throw new NotImplementedException();
            }

            
        }
    }
}
