using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter6
{
    class Manager : Employee
    {
        public Manager() { }

        public Manager(string fullName, int age, int empID, float currPay, string ssn, int stockOptions) : base(fullName, age, empID, currPay, ssn)
        {
            StockOptions = stockOptions;
        }

        public int StockOptions { get; set; }
    }
}
