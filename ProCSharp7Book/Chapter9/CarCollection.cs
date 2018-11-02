using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter9
{
    public class CarCollection : IEnumerable
    {
        private ArrayList arCars = new ArrayList();

        //Cast for caller.
        public Car GetCar(int pos) => (Car)arCars[pos];

        //Insert only Car objects.
        public void AddCar(Car c) => arCars.Add(c);
        public void ClearCars() => arCars.Clear();
        public int Count => arCars.Count;
        IEnumerator IEnumerable.GetEnumerator() => arCars.GetEnumerator();
    }
}
