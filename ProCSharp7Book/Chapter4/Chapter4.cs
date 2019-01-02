using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter4
{
    internal class Chapter4
    {
        enum EmpType: byte
        {
            Manager = 10,
            Grunt = 1,
            Contractor = 100,
            VicePresident = 9
        }

        internal int AMethodAddWithinAMethodNewIn7(int x, int y)
        {
            //a method, inside another method?  But you could do Anonymous Delegate Functions and Actions to achieve this?  Weird
            int Add(int a, int b) => a + b;

            return Add(x, y);
        }

        //This method will print out the details of any enum
        static void EvaluateEnum(Enum e)
        {
            Console.WriteLine($"=> Information about {e.GetType().Name}");
            Console.WriteLine($"Underlying stroage type: {Enum.GetUnderlyingType(e.GetType())}");

            //Get all the name value pairs for incoming parameter.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine($"This enum has {enumData.Length} members.");

            //Now show the string name and associated value, using the D format flag.
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine($"Name: {enumData.GetValue(i)}, Value: {enumData.GetValue(i):D}");
            }
        }

        internal void FunWithEnums()
        {
            Console.WriteLine("*******Fun with Enums********");

            EmpType e2 = EmpType.Contractor;

            //These types are enums in the System namespace.
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;

            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);
        }
    }
}
