﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter9
{
    class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            if(firstPerson?.Age > secondPerson?.Age)
            {
                return 1;
            }
            if(firstPerson?.Age < secondPerson?.Age)
            {
                return -1;
            }
            return 0;
        }
    }
}
