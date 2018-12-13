using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter12
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
        

        public void Accelerate(int delta)
        {
            //If this car is "dead", send dead message.
            if (carIsDead)
            {
                Console.WriteLine("Sorry, this car is dead....");
            }
            else
            {
                CurrentSpeed += delta;

                //Is the car "almost dead"?
                if (10 == (MaxSpeed - CurrentSpeed))
                {
                    Console.WriteLine("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
            }
        }
    }
}
