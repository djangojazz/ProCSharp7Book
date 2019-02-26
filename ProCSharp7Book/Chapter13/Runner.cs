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

        internal static void GCFun()
        {
            Console.WriteLine("********** Fun with GC **********");

            //Print out estimated number of bytes on heap.
            Console.WriteLine($"Estimate bytes on heap {GC.GetTotalMemory(false)}");

            //MaxGeneration is zero based, so add 1 for display purposes.
            Console.WriteLine($"This OS has {GC.MaxGeneration + 1} object generations");
            Car reftoCar = new Car("Zippy", 100);
            Console.WriteLine(reftoCar.ToString());

            //Print out generate of reftoCar
            Console.WriteLine($"Generation of refToMyCar is {GC.GetGeneration(reftoCar)}");
        }
    }
}
