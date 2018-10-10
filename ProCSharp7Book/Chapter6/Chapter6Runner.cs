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
    }
}
