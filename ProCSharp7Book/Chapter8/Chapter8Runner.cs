using ProCSharp7Book.Chapter7;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter8
{
    public static class Chapter8Runner
    {
        public static void InterfaceClashes()
        {
            Console.WriteLine("****** Fun with Interface Name Clashes ****\n");
            Octagon o = new Octagon();

            //Long form
            IDrawToForm idrawToForm = (IDrawToForm)o;
            idrawToForm.Draw();

            //Shorter form
            ((IDrawToPrinter)o).Draw();

            //Using the 'is a' methodology
            if(o is IDrawToMemory dtm)
                dtm.Draw();
        }

        public static void InterfaceInheritanceExample()
        {
            Console.WriteLine("****** Simple Inteface Hierarchy *****\n");

            //Call from object level.
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpsideDown();

            //Get IAdvancedDraw explicitly.
            IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
            if (iAdvDraw != null)
                iAdvDraw.DrawUpsideDown();
            Console.ReadLine();
        }

        public static void YieldKeyword()
        {
            Console.WriteLine("***** Fun with the Yield Keyword ****\n");
            Garage carLot = new Garage();

            //Get the items using GetEnumerator().
            foreach (Car c in carLot)
            {
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
            }

            //Get items in reverse using named operator
            foreach (Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine($"{c.PetName} is going {c.CurrentSpeed} MPH");
            }
        }

        public static void FunWithCloning()
        {
            Console.WriteLine("***** Fun with Object Cloning *******\n");
            System.Drawing.Point p1 = new System.Drawing.Point(50, 50);
            System.Drawing.Point p2 = p1;
            p2.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            //Cloneable interface
            Console.WriteLine("Cloned p3 and stored new Point in p4");
            Point p3 = new Point(100, 100, "Jane");
            Point p4 = (Point)p3.Clone();

            Console.WriteLine("Before modification");
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            p4.desc.PetName = "My new Point";
            p4.X = 9;

            Console.WriteLine("\nChanged p4.desc.petName and p4.X");
            Console.WriteLine("After modification");
            Console.WriteLine(p3);
            Console.WriteLine(p4);
        }

        public static void FunWithObjectSorting()
        {
            Console.WriteLine("***** Fun with Object Sorting ****\n");

            //Make an array of Car objects.
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);

            //Display the current Array.
            Console.WriteLine("Here is the unordered set of cars:");
            foreach (Car c in myAutos)
                Console.WriteLine($"{c.CarID} {c.PetName}");

            //Now sort them using IComparable!
            Array.Sort(myAutos, new PetNameComparer());
            Console.WriteLine();

            //Display sorted array.
            Console.WriteLine("Here is the sorted set of cars:");
            foreach (Car c in myAutos)
                Console.WriteLine($"{c.CarID} {c.PetName}");
        }
    }
}
