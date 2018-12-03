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
        
        public delegate void CarEngineHandler(object sender, CarEventArgs e);
        //public delegate void CarEngineHandler(string msgForCaller);

        //This car can send these events.
        public event EventHandler<CarEventArgs> Exploded;
        public event EventHandler<CarEventArgs> AboutToBlow;

        public CarEngineHandler listOfHandlers;
        
        public void RegisterWithCarEngineHandler(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall;
        }

        public void UnRegisterWithCarEngineHandler(CarEngineHandler methodToCall)
        {
            listOfHandlers -= methodToCall;
        }
        
        public void Accelerate(int delta)
        {
            //If the car is dead, fire exploded event.
            if(carIsDead)
            {
                Exploded?.Invoke(this, new CarEventArgs("Sorry, this car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;

                //Almost dead?
                if (10 == MaxSpeed - CurrentSpeed && AboutToBlow != null)
                    AboutToBlow(this, new CarEventArgs("Careful buddy! Gonna blow!"));

                //Still OK
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine($"Current Speed = {CurrentSpeed}");
            }

            //if (listOfHandlers != null)
            //    listOfHandlers("Sorry, this car is dead...");

            ////If this car is "dead", send dead message.
            //if(carIsDead)
            //{
            //    listOfHandlers?.Invoke("Sorry, this car is dead....");
            //}
            //else
            //{
            //    CurrentSpeed += delta;

            //    //Is the car "almost dead"?
            //    if(10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
            //    {
            //        listOfHandlers("Careful buddy! Gonna blow!");
            //    }
            //    if (CurrentSpeed >= MaxSpeed)
            //        carIsDead = true;
            //    else
            //        Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
            //}
        }
    }
}
