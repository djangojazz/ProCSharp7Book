using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter8
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        //Will override similar interfaces to do the same thing.
        //public void Draw()
        //{
        //    Console.WriteLine("Drawing the octagon...");
        //}

        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form...");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory...");
        }

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to printer...");
        }
    }
}
