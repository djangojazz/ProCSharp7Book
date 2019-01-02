using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter13
{
    public class Car
    {
        //Internal state data.
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        public Car() { }
        public Car(string name, int currSp)
        {
            CurrentSpeed = currSp;
            PetName = name;
        }

        public override string ToString() => $"{PetName} is going {CurrentSpeed} MPH";
    }
}