using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter6
{
    class Car
    {
        public readonly int maxSpeed;
        private int currSpeed;

        public Car(int max)
        {
            maxSpeed = max;
        }

        public Car()
        {
            maxSpeed = 55;
        }

        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if(currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        }
    }
}
