using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter10
{
    public class Car
    {
        //Internal state data.
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        private bool carIsDead;

        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        //1. Define a delegate type
        public delegate void CarEngineHandler(string msgForCaller);

        //2. Define a member variable of this delegate.
        private CarEngineHandler listOfHandlers;

        //3. Add Registration function for the caller.
        public void RegisterWithCarEngineHandler(CarEngineHandler methodToCall)
        {
            listOfHandlers = methodToCall;
        }

        //4. Implement the Accelerate() method to invoke the delegate's invocation list under the correct circumstances.
        public void Accelerate(int delta)
        {
            //If this car is "dead", send dead message.
            if(carIsDead)
            {
                listOfHandlers?.Invoke("Sorry, this car is dead....");
            }
            else
            {
                CurrentSpeed += delta;

                //Is the car "almost dead"?
                if(10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
            }
        }
    }
}
