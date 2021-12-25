using System;

namespace LaptevTask2 {
    public class Person {
        private string Name {
            get;
        }
        
        private int age;

        private int Age {
            get {
                return age;
            }
            set {
                if (value < 0) value = 0;
                age = value;
            }
        }

        protected Person(string name, int age) {
            Name = name;
            Age = age;
        }

        public virtual void Print() {
            Console.WriteLine(Name + " " + Age);
        }

        public override string ToString() => $"{Name}{Age}";

        public override int GetHashCode() => Name.GetHashCode() ^ Age.GetHashCode();

        public override bool Equals(object obj) {
            if (obj == null) {
                return false;
            }
            if (obj.GetType() != GetType()) {
                return false;
            }
            var p = obj as Person;
            return p.Name == Name && p.Age == Age;
        }

        public static void RandomPerson(Person[] per) {
            Console.WriteLine(per[new Random().Next(0, per.Length)]);
        }

        public static bool operator ==(Person p1, Person p2) {
            return p1.Equals(p2);
        }

        public static bool operator !=(Person p1, Person p2) {
            return !(p1 == p2);
        }
    }
}