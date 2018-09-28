using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter5
{
    // A simple savings account class.
    class SavingsAccount
    {
        //Instance-level data.
        public double currBalance;

        //A static point of data.
        public static double currInterestRate;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        static SavingsAccount()
        {
            Console.WriteLine("In static ctor");
            currInterestRate = 0.04;
        }

        //Static members to get/set the interest rate.
        public static void SetInterestRate(double newRate) => currInterestRate = newRate;
        public static double GetInterstRate() => currInterestRate;
    }
}
