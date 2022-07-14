using Lavoro._11._07._2022.Interfacce;
using System;

namespace Lavoro._11._07._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Abreham = new Person("f23tiqwe");
            LocalBank Hype = new LocalBank();
            
            Hype.OpenAccount(Abreham);
            Hype.CheckAccount(Abreham);
            Hype.Deposit(Abreham, 1000M);
            Hype.Withdraw(Abreham,500M);
            Hype.Withdraw(Abreham,800M);



        }

    }
}
