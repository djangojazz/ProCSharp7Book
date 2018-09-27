using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter5
{
    class Car
    {
        //The 'state' of the car
        public string petName;
        public int currSpeed;

        //a custom default constructor
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        //Here, currSpeed will receive the default value of an int (zero).
        public Car(string pn) => petName = pn;

        //Let the caller set the full state of the Car.
        public Car(string pn, int cs) => (petName, currSpeed) = (pn, cs);

        //The functionality of the car.
        //Using the expression-bodied member syntax introduced in C#6
        public void PrintState() => Console.WriteLine($"{petName} is going {currSpeed}.");
        public void SpeedUp(int delta) => currSpeed += delta;
    }
}
