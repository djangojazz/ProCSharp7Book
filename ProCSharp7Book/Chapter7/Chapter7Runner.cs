using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter7
{
    internal static class Chapter7Runner
    {
        public static void CarStart()
        {
            Console.WriteLine("******** Simple Exception Example ********");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            for (int i = 0; i < 10; i++)
                myCar.Accelerate(10);       
        }

        public static void CarExceptionHandling()
        {
            Console.WriteLine("******** Simple Exception Example ********");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");
                Console.WriteLine($"Member Name: {e.TargetSite}");
                Console.WriteLine($"Class defining Member: {e.TargetSite.DeclaringType}");
                Console.WriteLine($"Member type: {e.TargetSite.MemberType}");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Source: {e.Source}");
                Console.WriteLine($"Stack: {e.StackTrace}");
                Console.WriteLine($"Source: {e.HelpLink}");
                foreach(DictionaryEntry de in e.Data)
                    Console.WriteLine($"{de.Key} {de.Value}");
            }

            //The error has been handled, processing continues with the next statement.
            Console.WriteLine("\n***** Out of exception logic ******");
        }

        public static void CarCustomExceptionHandling()
        {
            Console.WriteLine("******** Simple Exception Example ********");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (CarIsDeadException e)
            {
                try
                {
                    FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.ErrorTimeStamp);
                    Console.WriteLine(e.CauseOfError);
                }
                catch (Exception e2)
                {
                    throw new CarIsDeadException(e.Message, e2);
                }
            }

            //The error has been handled, processing continues with the next statement.
            Console.WriteLine("\n***** Out of exception logic ******");
        }

        public static void CarHandlingMultipleExceptions()
        {
            Console.WriteLine("******** Handling Multiple Exceptions Example ********");
            Car myCar = new Car("Rusty", 90);
            myCar.CrankTunes(true);

            try
            {
                myCar.Accelerate(-10);
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
