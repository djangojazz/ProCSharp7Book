using ProCSharp7Book.Chapter7;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter8
{
    class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("FeeFee", 200);
            carArray[1] = new Car("Clunker", 90);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Car c in carArray)
            {
                yield return c;
            }
        }

        public IEnumerable GetTheCars(bool returnReversed)
        {
            //do some error checking here
            return actualImplementation();

            IEnumerable actualImplementation()
            {
                //Return the items in reverse.
                if(returnReversed)
                {
                    for (int i = carArray.Length; i != 0; i--)
                    {
                        yield return carArray[i - 1];
                    }
                }
                else
                {
                    //Return the items as placed in an array.
                    foreach (Car c in carArray)
                    {
                        yield return c;
                    }
                }
            }
        }
    }
}
