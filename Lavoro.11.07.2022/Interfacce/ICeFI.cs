namespace Lavoro._11._07._2022.Interfacce
{
    public interface ICeFI : IFinancialPolicy, IFinancialService
    {
        public bool TransactFiat { get; }
        public bool TransactCrypto { get; }       
    }

    public interface ICryptoService : ICeFI
    {
        public abstract void Withdraw(Person person, decimal Amount, TickerCrypto tickerCrypto);
        public abstract void Deposit(Person person, decimal Amount, TickerCrypto tickerCrypto);
    }
    public interface ICashService : ICeFI
    {
        public abstract void Withdraw(Person person, decimal Amount, TickerCash TickerCash);
        public abstract void Deposit(Person person, decimal Amount, TickerCash TickerCash);
    }
    public  interface IStockService : ICeFI
    {
        public abstract void Withdraw(Person person, decimal Amount, TickerStock TickerStock);
        public abstract void Deposit(Person person, decimal Amount, TickerStock TickerStock);
    }

}
