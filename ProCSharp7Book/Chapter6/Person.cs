using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter6
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }

        public Person() { }
        public override string ToString() => $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";
        public override bool Equals(object obj)
        {
            if(obj is Person && obj != null)
            {
                Person temp;
                temp = (Person)obj;
                if (temp.FirstName == this.FirstName && temp.LastName == this.LastName && temp.Age == this.Age)
                    return true;
                else
                    return false;
            }

            return false;
        }
        public override int GetHashCode() => ToString().GetHashCode();
    }
}
