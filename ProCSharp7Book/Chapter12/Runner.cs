using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter12
{
    internal class Runner
    {

        internal static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            var subset = from i in numbers where i < 10 select i;

            foreach (int i in subset)
                Console.WriteLine($"Item: {i}");

            ReflectOverQueryResults(subset);
        }


        internal static void FilteringDataUsingTypeOfInt()
        {
            //Extract the ints from the ArrayList.
            var myStuff = new ArrayList();
            myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });
            var myInts = myStuff.OfType<int>();

            //Prints out only the ints
            foreach (int i in myInts)
                Console.WriteLine($"Int value: {i}");
        }

        private static void ReflectOverQueryResults(object resultSet, string queryType = "Query Expressions")
        {
            Console.WriteLine($"******** Info about your query using {queryType} *******");
            Console.WriteLine($"Resultset is of type: {resultSet.GetType().Name}");
            Console.WriteLine($"resultset location: {resultSet.GetType().Assembly.GetName().Name}");
        }
    }
}
