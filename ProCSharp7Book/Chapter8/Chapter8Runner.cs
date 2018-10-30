using ProCSharp7Book.Chapter7;
using System;
using System.Collections.Generic;
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
    }
}
