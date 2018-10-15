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

        internal static void Shapes()
        {
            Console.WriteLine("**** Fun with Polymorphism ******\n");
            var hex = new Hexagon("Beth");
            hex.Draw();

            var cir = new Circle("Cindy");
            cir.Draw();
        }

        internal static void ShapeArrays()
        {
            Console.WriteLine("**** Fun with Polymorphism ******\n");
            Shape[] myShapes = { new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda") };

            myShapes.ToList().ForEach(x => x.Draw());
        }

        internal static void ThreeDCircle()
        {
            ShapeArrays();
            var o = new ThreeDCircle();
            //shadow methods
            o.Draw();

            //This calls the Draw() method of the parent!
            ((Circle)o).Draw();
        }

        internal static void Objects()
        {
            Console.WriteLine("**** Fun with System.Object ********\n");
            var p1 = new Person();

            Console.WriteLine($"ToString: {p1.ToString()}");
            Console.WriteLine($"HashCode: {p1.GetHashCode()}");
            Console.WriteLine($"Type: {p1.GetType()}");

            Person p2 = p1;
            object o = p2;
            if(o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same Instance!");
            }
        }

        internal static void PersonTesting()
        {
            Console.WriteLine("**** Fun with System.Object ****\n");

            Person p1 = new Person("Homer", "Simpson", 50);
            Person p2 = new Person("Homer", "Simpson", 50);

            Console.WriteLine($"p1.ToString() = {p1.ToString()}");
            Console.WriteLine($"p2.ToString() = {p2.ToString()}");
            Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}");
            Console.WriteLine($"Same hash codes?: {p1.GetHashCode() == p2.GetHashCode()}");

            p2.Age = 45;
            Console.WriteLine($"p1.ToString() = {p1.ToString()}");
            Console.WriteLine($"p2.ToString() = {p2.ToString()}");
            Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}");
            Console.WriteLine($"Same hash codes?: {p1.GetHashCode() == p2.GetHashCode()}");

            //Static members of the System.Object
            Person p3 = new Person("Sally", "Jones", 4);
            Person p4 = new Person("Sally", "Jones", 4);
            Console.WriteLine($"P3 and P4 have same state: {object.Equals(p3, p4)}");
            Console.WriteLine($"P3 and P4 are pointing to the same object: {object.ReferenceEquals(p3, p4)}");
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine($"{emp.Name} was promoted!");
            //Pattern matching:
            switch(emp)
            {
                case SalesPerson s when s.SalesNumber > 5:
                    Console.WriteLine($"{emp.Name} made {s.SalesNumber} sale(s)");
                    break;
                case Manager m:
                    Console.WriteLine($"{emp.Name} had {m.StockOptions} stock options)");
                    break;
                case Intern _:
                    break;
                case null:
                    break;
            }

            //if(emp is SalesPerson s)
            //{
            //    //old
            //    //Console.WriteLine($"{emp.Name} made {((SalesPerson)emp).SalesNumber} sale(s)");
            //    //new in c7 uses the alias of 's' if cast succeeded.
            //    Console.WriteLine($"{emp.Name} made {s.SalesNumber} sale(s)");
            //}
            //if (emp is Manager m)
            //{
            //    Console.WriteLine($"{emp.Name} had {m.StockOptions} stock options)");
            //}
        }
    }
}
