﻿namespace Lavoro._11._07._2022.Interfacce
{
    public interface IFinancialService
    {
        public void OpenAccount(Person person);
        public void CloseAccount(Person person, int AccountNumber);
        public string CheckAccount(Person person);
    }
}   
    