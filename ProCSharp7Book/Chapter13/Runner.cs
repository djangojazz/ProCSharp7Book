using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter13
{
    internal static class Runner
    {
        internal static void GCBasics()
        {
            Console.WriteLine("********** GC Basics **********");

            //Create a new car object on the managed heap.  We are returning a reference to this object.
            var refToMyCar = new Car("Zippy", 50);

            //The C# dot operator(.) is used to invoke members on the object using our reference variable.
            Console.WriteLine(refToMyCar.ToString());
        }
    }
}
