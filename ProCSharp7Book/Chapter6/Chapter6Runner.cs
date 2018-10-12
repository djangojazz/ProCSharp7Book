using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter6
{
    internal static class Chapter6Runner
    {
        internal static void RunCarExample()
        {
            Console.WriteLine("****** Basic Inheritance ********\n");
            //Make a car object and set max speed.
            Car myCar = new Car(80);

            //Set the current speed, and print it
            myCar.Speed = 50;
            Console.WriteLine($"Car is going {myCar.Speed}");
        }

        internal static void RunMiniVanExample()
        {
            Console.WriteLine("****** Basic Inheritance ********\n");
            //Make a car object and set max speed.
            MiniVan van = new MiniVan();

            //Set the current speed, and print it
            van.Speed = 10;
            Console.WriteLine($"Van is going {van.Speed}");
        }

        internal static void EmployeeClassHeirarchy()
        {
            Console.WriteLine("****** Employee Class Heirarchy ********\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
        }

        internal static void EmployeeOverridingExamples()
        {
            Console.WriteLine("****** Employee Class Heirarchy ********\n");
            //A better bonus system!
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(500);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
        }
    }
}
