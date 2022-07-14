using Lavoro._11._07._2022.Interfacce;
using System;

namespace Lavoro._11._07._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Abreham = new Person("f23tiqwe");
            LocalBanck Hype = new LocalBanck();
            
            Hype.OpenAccount(Abreham);
            string aCCOUNT =   Hype.CheckAccount(Abreham);

            Console.WriteLine(aCCOUNT);
        }
        
    }
}
