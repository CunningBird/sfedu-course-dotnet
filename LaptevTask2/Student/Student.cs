using System;

namespace LaptevTask2
{
    public class Student : Person
    {
        int Course {
            get;
        }

        int Group {
            get;
        }

        public Student(string name, int age, int course, int group) : base(name, age) {
            Group = group;
            Course = course;
        }

        public override void Print() {
            base.Print();
            Console.WriteLine(Course + " " + Group);
        }

        public override string ToString() => base.ToString() + $"{Course}{Group}";

        public override int GetHashCode() => base.GetHashCode() ^ Group.GetHashCode() ^ Course.GetHashCode();

        public override bool Equals(object obj) {
            var s = obj as Student;
            return base.Equals(obj) && s.Group == Group && s.Course == Course;
        }

        public static void RandomStudent(Student[] stud) {
            Console.WriteLine(stud[new Random().Next(0, stud.Length)]);
        }

        public static bool operator ==(Student s1, Student s2) {
            return s1.Equals(s2);
        }

        public static bool operator !=(Student s1, Student s2) {
            return !(s1 == s2);
        }
    }
}