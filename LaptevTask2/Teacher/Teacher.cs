using System;
using System.Collections.Generic;
using System.Linq;

namespace LaptevTask2 {
    public class Teacher : Person {
        string Department {
            get;
        }

        public List<Student> Students {
            get;
            set;
        }

        public Teacher(string name, int age, string department, List<Student> students) : base(name, age) {
            Department = department;
            Students = students;
        }

        public override void Print() {
            base.Print();
            Console.WriteLine(Department);
            for (int i = 0; i < Students.Count(); ++i) {
                Students[i].Print();
            }
        }

        public override string ToString() => base.ToString() + $"{Department}{Students}";

        public override int GetHashCode() => base.GetHashCode() ^ Department.GetHashCode() ^ Students.GetHashCode();

        public override bool Equals(object obj) {
            var t = obj as Teacher;
            return base.Equals(obj) && t.Department == Department && t.Students == Students;
        }

        public static void RandomTeacher(Teacher[] teach) {
            Console.WriteLine(teach[new Random().Next(0, teach.Length)]);
        }

        public static bool operator ==(Teacher t1, Teacher t2) {
            return t1.Equals(t2);
        }

        public static bool operator !=(Teacher t1, Teacher t2) {
            return !(t1 == t2);
        }
    }
}