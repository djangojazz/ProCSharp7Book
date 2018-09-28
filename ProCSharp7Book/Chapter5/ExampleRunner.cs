using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter5
{
    public static class ExampleRunner
    {
        public static void RunACar()
        {
            Console.WriteLine("******* Fun with Class Types *********\n");
            
            Car chuck = new Car();
            chuck.PrintState();

            Car mary = new Car("Mary");
            mary.PrintState();

            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            Action<Motorcycle> print = x => Console.WriteLine($"Name {x.driverName}, Intensity {x.driverIntensity}");

            //Make a motorcycle
            Motorcycle c = new Motorcycle();
            print(c);
            Motorcycle c2 = new Motorcycle(name: "Tiny");
            print(c2);
            Motorcycle c3 = new Motorcycle(7);
            print(c3);

            Console.ReadLine();
        }

        public static void StaticExamples()
        {
            Console.WriteLine("****** Fun with static examples ******\n");
            SavingsAccount s1 = new SavingsAccount(50);
            
            //Print the current interest rate.
            Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterstRate()}");

            SavingsAccount.SetInterestRate(0.08);

            SavingsAccount s2 = new SavingsAccount(100);
            
            Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterstRate()}");

            Console.ReadLine();
        }
        
        public static void StaticClassExample()
        {
            //this is just fine 
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            //Won't work on statics
            //TimeUtilClass c = new TimeUtilClass();
            Console.ReadLine();
        }
    }
}
