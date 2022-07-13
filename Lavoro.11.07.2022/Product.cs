namespace Lavoro._11._07._2022
{
    public abstract class Product 
    {
        protected Account Account;
        protected int id;
        protected decimal ammount;
    } // questa
    public class Cash : Product
    {
        int _id;
        decimal _amount;

        public enum tickerCash
        {
            euro,
            dollaro,
            yen,
        }
    }
    public class Cryto : Product
    {
        int _id;
        decimal _amount;
        public enum tickerCrypto
        {
            Btc,
            Eth,
            Bnb,
        }
    }
    public class Stock : Product
    {
        int _id;
        decimal _amount;
        public enum tickerStock
        {
            Tesla,
            Amazon,
            CocaCola,
        }
    }
}

