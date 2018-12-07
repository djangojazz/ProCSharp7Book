using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter11
{
    internal static class Runner
    {
        internal static void InternalStaticLooping(string[] args)
        {
            //Loop over incoming command line arguments using index operator.
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine($"Args: {args[i]}");

            //Declare an array of local integers.
            int[] myInts = { 10, 9, 100, 432, 9874 };

            //Use the index operator to access each element.
            for (int j = 0; j < myInts.Length; j++)
                Console.WriteLine($"Index {j} = {myInts[j]}");
        }

        internal static void FunWithAnnonymousTypes()
        {
            Console.WriteLine("****** Fun with Annonymous Types *******\n");

            //Make an annonymous type representing a car.
            var car1 = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            var car2 = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            //Are they considered equal when using Equals()?
            if(car1.Equals(car2))
                Console.WriteLine("Same anonmymous object!");
            else
                Console.WriteLine("Not the same anonymous object!");

            //Are they considered equal with ==?
            if (car1 == car2)
                Console.WriteLine("Same anonymous object");
            else
                Console.WriteLine("Not the same");

            //Same underlying type
            if(car1.GetType().Name == car2.GetType().Name)
                Console.WriteLine("We are both the same type!");
            else
                Console.WriteLine("We are different types!");

            //Reflect over what the compiler generated.
            Console.WriteLine();
            ReflectOverAnnonymousType(car1);
            ReflectOverAnnonymousType(car2);
        }

        static void ReflectOverAnnonymousType(object obj)
        {
            Console.WriteLine($"obj is an instance of {obj.GetType().Name}");
            Console.WriteLine($"Base class of {obj.GetType().Name} is {obj.GetType().BaseType}");
            Console.WriteLine($"obj.ToString() == {obj.ToString()}");
            Console.WriteLine($"obj.GetHashCode() == {obj.GetHashCode()}");
            Console.WriteLine();
        }
        
    }
}
