namespace Lavoro._11._07._2022.Interfacce
{
    public interface IFinancialService
    {
        public void OpenAccount(Person person);
        public void CloseAccount();
        public void Withdraw(Person person, decimal Amount);
        public void Deposit(Person person, decimal Amount);
        public string CheckAccount(Person person);

    }


}
