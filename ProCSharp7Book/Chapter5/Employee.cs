using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter5
{
    class Employee
    {
        //Field data.
        private string empName;
        private int empId;
        private float currPay;

        //Constructors
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            empName = name;
            empId = id;
            currPay = pay;
        }

        //Accessor (get method).
        public string GetName()
        {
            return empName;
        }

        //Mutator (set method)
        public void SetName(string name)
        {
            //Do a check for incoming value before making assignment.
            if (name.Length > 15)
                Console.WriteLine("Error! Name length exceeds 15 characters");
            else
                empName = name;
        }

        //Methods.
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empId);
            Console.WriteLine("Pay: {0}", currPay);
        }
    }
}
