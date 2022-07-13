using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavoro._11._07._2022.Interfacce
{
   
    public interface IfinancialService
    {
        public void OpenAccount(Person person);
        public void CloseAccount();
        public int Withdraw();
        public decimal Deposti();
        public decimal CheckAccount();

    }
    public interface IFinancialPolicy
    {
        public string Kyc();
    }
    public interface ICefi : IFinancialPolicy, IfinancialService
    {
        public decimal TransactFiat();
        public decimal TransactCrypto();

    }
    public interface Idefi : IfinancialService
    {
        public decimal TransactCrypto();

    }

    public interface PaymentService : ICefi
    {
        public decimal StorePayments();
        public string EmmitCard();
    }
    public interface InternationaService
    {
        public string InternaTionalWithdraw();
    }
    public interface CreditSevice
    {
        public int Loans();
    }


}
