using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavoro._11._07._2022.Models
{
    public class CheckAccountResponse
    {  
        public int AccountNumber { get; set; }   
        public decimal Saldo { get; set; }
        public string Message { get; set; }
    }     
}
