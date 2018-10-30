using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter8
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing....");
        }

        public int GetNumberOfSides()
        {
            return 4;
        }

        public void Print()
        {
            Console.WriteLine("Printing....");
        }
    }
}
