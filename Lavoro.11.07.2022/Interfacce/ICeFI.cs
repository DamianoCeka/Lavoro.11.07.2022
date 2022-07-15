namespace Lavoro._11._07._2022.Interfacce
{
    public interface ICeFI : IFinancialPolicy, IFinancialService
    {
        public decimal TransactFiat();
        public decimal TransactCrypto();

    }


}
