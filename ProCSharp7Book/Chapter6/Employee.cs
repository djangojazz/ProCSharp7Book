using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter6
{
    class Employee
    {
        //Field data.
        private string empName;
        private int empId;
        private float currPay;
        private int empAge;

        //Constructors
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay, 0) { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            empName = name;
            empId = id;
            empAge = age;
            currPay = pay;
            SSN = ssn;
        }

        //Properties
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters");
                else
                    empName = value;
            }
        }

        public int Age
        {
          get => empAge; 
          set => empAge = value; 
        }

        public string SSN { get; set; }

        //Accessor (get method).
        //public string GetName()
        //{
        //    return empName;
        //}

        ////Mutator (set method)
        //public void SetName(string name)
        //{
        //    //Do a check for incoming value before making assignment.
        //    if (name.Length > 15)
        //        Console.WriteLine("Error! Name length exceeds 15 characters");
        //    else
        //        empName = name;
        //}

        //Methods.
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empId);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
        }
    }
}
