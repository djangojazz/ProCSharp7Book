using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter5
{
    public static class ExampleRunner
    {
        public static void RunACar()
        {
            Console.WriteLine("******* Fun with Class Types *********\n");
            
            Car chuck = new Car();
            chuck.PrintState();

            Car mary = new Car("Mary");
            mary.PrintState();

            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();

            Motorcycle mc = new Motorcycle();
            
            Console.ReadLine();
        }
    }
}
