using System;

namespace LaptevTask2 {
    public class StudentWithAdvisor : Student {
        Teacher Teacher {
            get;
        }

        public StudentWithAdvisor(string name, int age, int course, int group, Teacher teacher) : base(name, age, course, group) {
            Teacher = teacher;
        }

        public override void Print() {
            base.Print();
            Console.WriteLine(Teacher);
        }

        public override string ToString() => base.ToString() + $"{Teacher}";

        public override int GetHashCode() => base.GetHashCode() ^ Teacher.GetHashCode();

        public override bool Equals(object obj) {
            var s = obj as StudentWithAdvisor;
            return base.Equals(obj) && s.Teacher == Teacher;
        }

        public static void RandomStudent(StudentWithAdvisor[] stud) {
            Console.WriteLine(stud[new Random().Next(0, stud.Length)]);
        }
    }
}