﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCSharp7Book.Chapter9
{
    internal static class Chapter9Runner
    {
        internal static void BasicArray()
        {
            //Make an array of string data.
            string[] strArray = { "First", "Second", "Third" };

            //Show number of itesm in array using Length property.
            Console.WriteLine($"This array has {strArray.Length}");
            Console.WriteLine();

            //Display contents using enumerator.
            foreach (string s in strArray)
            {
                Console.WriteLine($"Array Entry: {s}");
            }
            Console.WriteLine();

            //Reverse the array and print again.
            Array.Reverse(strArray);
            foreach (string s in strArray)
            {
                Console.WriteLine($"Array Entry: {s}");
            }
        }
        
        internal static void PersonCollection()
        {
            Console.WriteLine("***** Custom Person Collection ******");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));

            //This would be a compile time error!
            //myPeople.AddPerson(new Car());

            foreach (Person p in myPeople)
            Console.WriteLine(p);
        }

        internal static void GenericList()
        {
            Console.WriteLine("**** Fun with Generics *****\n");

            //This List<> can hold only Person objects.
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Frank", "Black", 50));
            Console.WriteLine(morePeople[0]);

            //This List<> can hold only integers
            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum = moreInts[0] + moreInts[1];
        }

        internal static void GenericStack()
        {
            Console.WriteLine("***** Custom Person Collection ******");
            Stack<Person> stackOfPeople = new Stack<Person>();

            // Now look at the top item, pop it, and look again.
            Console.WriteLine($"First Person is {stackOfPeople.Peek()}");
            Console.WriteLine($"Popped off {stackOfPeople.Pop()}");
            Console.WriteLine($"\nFirst Person is {stackOfPeople.Peek()}");
            Console.WriteLine($"Popped off {stackOfPeople.Pop()}");
            Console.WriteLine($"\nFirst Person is {stackOfPeople.Peek()}");
            Console.WriteLine($"Popped off {stackOfPeople.Pop()}");

            try
            {
                Console.WriteLine($"\n\nFirst Person is {stackOfPeople.Peek()}");
                Console.WriteLine($"Popped off {stackOfPeople.Pop()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError! {ex.Message}");
            }
        }

        internal static void GenericQueue()
        {
            void GetCoffee(Person p)
            {
                Console.WriteLine($"{p.FirstName} got coffee!");
            }

            Console.WriteLine("***** Custom Person Collection ******");
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person("Homer", "Simpson", 40));
            peopleQ.Enqueue(new Person("Marge", "Simpson", 38));
            peopleQ.Enqueue(new Person("Lisa", "Simpson", 9));

            //Peek at first person in Q.
            Console.WriteLine($"{peopleQ.Peek().FirstName} is first in line");

            // Now look at the top item, pop it, and look again.
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());

            //Try to dequeue again.
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError! {ex.Message}");
            }
        }

        internal static void StoredPeople()
        {
            Console.WriteLine("***** Sorted PersonSet ******");

            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
                new Person("Homer", "Simpson", 40),
                new Person("Marge", "Simpson", 38),
                new Person("Lisa", "Simpson", 9),
                new Person("Bart", "Simpson", 7)
            };

            foreach (Person p in setOfPeople)
                Console.WriteLine(p);

            Console.WriteLine();

            setOfPeople.Add(new Person("Saku", "Jones", 1));
            setOfPeople.Add(new Person("Mikko", "Jones", 32));

            foreach (Person p in setOfPeople)
                Console.WriteLine(p);
        }

        internal static void WorkingWithObservableCollection()
        {
            //Make a collection to observe and add a few people.
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person("Peter", "Murphy", 52),
                new Person("Kevin", "Key", 48)
            };

            //Wire up the collection changed argument event.
            people.CollectionChanged += people_CollectionChanged;

            //Make some changes
            people.Remove(people.Last());
            people.Add(new Person("Brett", "Me", 40));
            people.Last().LastName = "Morin";

        }
        
        internal static void FunWithGenericSwap()
        {
            Console.WriteLine("****** Fun with Custom Generic Methods ******\n");

            //Swap 2 ints.
            int a = 10, b = 90;
            Console.WriteLine($"Before the swap: {a}, {b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"After the swap: {a}, {b}");
            Console.WriteLine();

            //Swap 2 string.
            string s1 = "Hello", s2 = "There";
            Console.WriteLine($"Before the swap: {s1}, {s2}");
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"After the swap: {s1}, {s2}");
            Console.WriteLine();
        }

        private static void people_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //What was the action that caused the event?
            Console.WriteLine($"Action for this event: {e.Action}"); ;

            //They removed something.
            if(e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are OLD items:");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }

            //They added something.
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                //Now show the NEW items that were inserted.
                Console.WriteLine("Here are the NEW items:");
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }
        
        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine($"You sent the swap() method a {typeof(T)}");
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
