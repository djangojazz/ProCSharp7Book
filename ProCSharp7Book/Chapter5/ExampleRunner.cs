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
            
            Car c = new Car();
            c.PetName = "Chuck";
            c.Speed = 55;
            c.Color = "Red";

            c.DisplayStats();
            Action<Motorcycle> print = x => Console.WriteLine($"Name {x.driverName}, Intensity {x.driverIntensity}");

            //Make a motorcycle
            Motorcycle cyc = new Motorcycle();
            print(cyc);
            Motorcycle c2 = new Motorcycle(name: "Tiny");
            print(c2);
            Motorcycle c3 = new Motorcycle(7);
            print(c3);

            Console.ReadLine();
        }

        public static void HaveAGarage()
        {
            Console.WriteLine("******* Fun with automatic properties ******\n");

            //Make a car.
            Car c = new Car();
            c.PetName = "Frank";
            c.Speed = 55;
            c.Color = "Red";
            c.DisplayStats();

            //Put car in the garage.
            Garage g = new Garage();
            g.MyAuto = c;
            Console.WriteLine("Number of Cars in garage: {0}", g.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", g.MyAuto.PetName);
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

        public static void Employees()
        {
            Console.WriteLine("******** Fun with Encapsulation ******\n");
            Employee emp = new Employee("Marvin", 456, 30_000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            //Use the get/set methods to interact with the object's name.
            emp.Name = "Marv";
            Console.WriteLine($"Employee is named: {emp.Name}");
        }
    }
}
