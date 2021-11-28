using System;
using System.Collections.Generic;
using InterfacesLib;
using ICloneable = InterfacesLib.ICloneable;

namespace PersonLib
{
    public class Person : IPrintable, ICloneable, IDisposable
    {
        private string name;
        private bool disposed = false;

        public string Name {
            get { return name; }
            set { if (value.Length > 0) name = value; }
        }

        private int age;

        public int Age {
            get { return age; }
            set { if (value > 0) age = value; }
        }

        public Person(string name, int age) {
            Name = name;
            Age = age;
        }

        public void Print() {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        public override string ToString() {
            string StringFormat = $"Name: {Name}, Age: {Age}, Type: Person";
            return StringFormat;
        }

        public override bool Equals(object obj) {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) {
                return false;
            }
            
            var p = obj as Person;
            return (Name == p.Name) && (Age == p.Age);
        }

        public override int GetHashCode() {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }

        public static Person RandomPerson(Person[] arr) {
            List<Person> filteredArr = new List<Person>();
            foreach (Person p in arr) {
                if (p.GetType() == typeof(Person)) {
                    if (p is Person s) {
                        filteredArr.Add(s);
                    }
                }
            }

            Random random = new Random();
            int random_el_index = random.Next(0, filteredArr.Count);
            if (filteredArr.Count > 0) {
                return filteredArr[random_el_index];
            }
            
            return null;
        }

        public ICloneable Clone() {
            return new Person(Name, Age);
        }

        public static bool operator !=(Person p1, Person p2) {
            return !p1.Equals(p2);
        }

        public static bool operator ==(Person p1, Person p2) {
            return p1.Equals(p2);
        }


        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
            Console.WriteLine("Disposed");
        }

        protected virtual void Dispose(bool disposing) {
            if (!disposed) {
                if (disposing) {}
                disposed = true;
            }
        }

        ~Person() {
            Dispose(false);
        }
    }
}