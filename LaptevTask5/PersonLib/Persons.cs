using System;
using System.Collections;
using System.Collections.Generic;

namespace PersonLib
{
    public class Persons : IEnumerable<Person>
    {
        private List<Person> listOfPersons;

        public Persons() {
            listOfPersons = new List<Person>();
        }

        public IEnumerator<Person> GetEnumerator() {
            for (int i = 0; i < listOfPersons.Count; i++) {
                Console.Write($"Index={i} ");
                yield return listOfPersons[i];
            }
        }

        public void Add(Person p) {
            listOfPersons.Add(p);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}