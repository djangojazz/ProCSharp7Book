using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter5
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;

        public void SetDriverName(string name)
        {
            driverName = name;
        }

        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeee Haaaaeeeewwww!");
            }
        }

        ////Put back the default constructor, which will set all data members to default values.
        //public Motorcycle()
        //{
        //    Console.WriteLine("In default ctor");
        //}

        ////Our custom constructor.
        //public Motorcycle(int intensity) : this(intensity, "")
        //{
        //    Console.WriteLine("In ctor taking an int");
        //}
        //public Motorcycle(string name): this(0, name)
        //{
        //    Console.WriteLine("In ctor taking a string");
        //}

        //This is the 'master' constructor
        public Motorcycle(int intensity = 0, string name = "")
        {
            Console.WriteLine("In master ctor");
            if(intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
    }
}
