using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter10
{
    internal static class Runner
    {
        //This delegate can point to any method, taking two integers and returning an integer
        public delegate int BinaryOp(int x, int y);

        internal static void SimpleDelegate()
        {
            Console.WriteLine("****** Simple Delegate Example *****");

            //Create a BinaryOp delegate object that "points to" SimpleMath.Add().
            BinaryOp b = new BinaryOp(new SimpleMath().Add);

            DisplayDelegateInfo(b);

            //Invoke Add() method indirectly using delegate object.
            Console.WriteLine($"10 + 10 is {b(10,10)}");
        }

        internal static void CarRunner()
        {
            Console.WriteLine("****** Delegates as event enablers *****\n");

            //First make a car
            Car c1 = new Car("SlugBug", 100, 10);

            //Now tell the car which method to call when it wants to send messages.
            c1.RegisterWithCarEngineHandler(new Car.CarEngineHandler(OnCarEngineEvent));

            //Speed up (this will trigger events).
            Console.WriteLine("***** Speeding up ******");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
        }

        private static void DisplayDelegateInfo(Delegate delObj)
        {
            //Print the names of each memeber in the delegate's invocation list.
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine($"Method Name: {d.Method}");
                Console.WriteLine($"Type Name: {d.Target}");
            }
        }

        private static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message from Car Object ******");
            Console.WriteLine($" => {msg}");
            Console.WriteLine("*********************************\n");
        }
    }
}
