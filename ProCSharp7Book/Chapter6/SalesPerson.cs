using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter6
{
    class SalesPerson : Employee
    {
        public SalesPerson() { }

        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales) : base(fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }
        public int SalesNumber { get; set; }
    }
}
