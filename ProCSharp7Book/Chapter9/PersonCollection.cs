using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter9
{
    public class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();

        //Cast for caller.
        public Person GetPerson(int pos) => (Person)arPeople[pos];

        //Insert only Person objects.
        public void AddPerson(Person p) => arPeople.Add(p);
        public void ClearPeople() => arPeople.Clear();
        public int Count => arPeople.Count;

        IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();
    }
}
