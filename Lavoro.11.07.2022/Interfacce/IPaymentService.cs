namespace Lavoro._11._07._2022.Interfacce
{
    public interface IPaymentService : ICeFI
    {
        public decimal StorePayments();
        public string EmmitCard();
    }


}
