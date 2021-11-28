using System;
using System.Collections.Generic;
using PersonLib;
using StudentLib;
using InterfacesLib;
using ICloneable = InterfacesLib.ICloneable;

namespace TeacherLib
{
    public class Teacher : Person, ICloneable
    {
        public List<Student> Students { get; set; }

        public Teacher(string Name, int Age, List<Student> students) : base(Name, Age) {
            Students = students;
        }

        public new void Print() {
            Console.WriteLine($"Name: {Name}, Age: {Age}, {Name}`s Students:");
            Console.Write("(");
            foreach (Student student in Students) {
                student.Print();
            }

            Console.WriteLine(")");
        }

        public override bool Equals(object obj) {
            if (!base.Equals(obj)) return false;
            var t = obj as Teacher;
            if (t.Students.Count != Students.Count) return false;
            int i = 0;
            foreach (Student s in Students) {
                if (s.Name != t.Students[i].Name || s.Age != t.Students[i].Age || s.Course != t.Students[i].Course) { return false; }
                i++;
            }

            return (true);
        }

        public override int GetHashCode() {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }

        public static Teacher RandomTeacher(Person[] arr) {
            List<Teacher> filteredArr = new List<Teacher>();
            foreach (Person p in arr) {
                if (p.GetType() == typeof(Teacher)) {
                    if (p is Teacher s) { filteredArr.Add(s); }
                }
            }

            Random random = new Random();
            int random_el_index = random.Next(0, filteredArr.Count);
            if (filteredArr.Count > 0) { return filteredArr[random_el_index]; }
            return null;
        }

        public new ICloneable Clone() {
            List<Student> studentsList = Students.ConvertAll(student => new Student(student.Name, student.Age, student.Course));
            return new Teacher(Name, Age, studentsList);
        }

        public static bool operator !=(Teacher t1, Teacher t2) {
            return !t1.Equals(t2);
        }

        public static bool operator ==(Teacher t1, Teacher t2) {
            return t1.Equals(t2);
        }
    }
}