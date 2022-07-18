namespace Lavoro._11._07._2022.Interfacce
{
    public interface ICeFI : IFinancialPolicy, IFinancialService
    {
        public bool TransactFiat { get; }
        public bool TransactCrypto { get; }       

    }

    public interface ICryptoService : ICeFI
    {
        public void Withdraw(Person person, decimal Amount, TickerCrypto tickerCrypto);
        public void Deposit(Person person, decimal Amount, TickerCrypto tickerCrypto);
    }
    public interface ICashService : ICeFI
    {
        public void Withdraw(Person person, decimal Amount, TickerCash TickerCash);
        public void Deposit(Person person, decimal Amount, TickerCash TickerCash);
    }
    public interface IStockService : ICeFI
    {
        public void Withdraw(Person person, decimal Amount, TickerStock TickerStock);
        public void Deposit(Person person, decimal Amount, TickerStock TickerStock);
    }

}
