using Chapter14.CarLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter14
{
    internal class Runner
    {
        internal static void ReferenceCarRunner()
        {
            Console.WriteLine("****** C# CarLibrary Client App ******");
            //Make a sports car.
            var viper = new SportsCar("Viper", 240, 40);
            viper.TurboBoost();

            //Make a minivan.
            var mv = new Minivan();
            mv.TurboBoost();

            Console.WriteLine("Done.  Press any key to terminate");
        }
    }
}
