using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter8
{
    class Car : IComparable
    {
        public const int MaxSpeed = 100;
        
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool carIsDead;

        private Radio theMusicBox = new Radio();
        public int CarID { get; set; }
        

        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public Car(string name, int currSpeed, int id): this(name, currSpeed)
        {
            CarID = id;
        }

        
        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (delta < 0)
                throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero!");

            if(carIsDead)
                Console.WriteLine($"{PetName} is out of order...");
            else
            {
                CurrentSpeed += delta;
                if(CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    carIsDead = true;

                    CarIsDeadException ex = new CarIsDeadException($"{PetName} has overheated!", "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "http://www.CarsRUs.com";
                    
                    throw ex;

                    //Exception ex = new Exception($"{PetName} has overheated!");
                    //ex.HelpLink = "http://www.CarsRUs.com";

                    //ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}");
                    //ex.Data.Add("Cause", "You have a lead foot");
                    //throw ex;
                }
                else
                    Console.WriteLine($"-> Current speed is {CurrentSpeed}");
            }
        }

        public int CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp != null)
                return this.CarID.CompareTo(temp.CarID);
            else
                throw new ArgumentException("Parameter is not a Car!");
        }
    }
}
