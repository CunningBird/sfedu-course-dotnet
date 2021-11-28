using System;
using PersonLib;
using InterfacesLib;
using ICloneable = InterfacesLib.ICloneable;

namespace StudentLib
{
    public class Student : Person, IPrintable, InterfacesLib.IComparable<Student>, ICloneable
    {
        private int course;

        public int Course {
            get { return course; }
            set { if (value > 0 && value <= 4) course = value; }
        }

        public Student(string name, int age, int course) : base(name, age) {
            Course = course;
        }

        public void IncCourse() {
            Course++;
        }

        public new void Print() {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Course: {Course}");
        }

        public override string ToString() {
            string StringFormat = $"Name: {Name}, Age: {Age}, Course: {Course}, Type: Student";
            return StringFormat;
        }

        public new ICloneable Clone() {
            return new Student(Name, Age, Course);
        }

        public int CompareTo(Student other) {
            var nb = Course.CompareTo(other.Course);
            if (nb != 0) { return nb; }

            nb = Age.CompareTo(other.Age);
            if (nb != 0) { return nb; }

            nb = Name.CompareTo(other.Name);
            return nb;
        }

        private class CompareStudent : IComparer<Student>
        {
            private CompareStudentBy _compareStudentBy;

            public CompareStudent(CompareStudentBy compareBy) { _compareStudentBy = compareBy; }

            public int Compare(Student a, Student b) {
                int np = 0;
                switch (_compareStudentBy) {
                    case CompareStudentBy.AGE:
                        np = a.Age.CompareTo(b.Age);
                        break;
                    case CompareStudentBy.NAME:
                        np = a.Name.CompareTo(b.Name);
                        break;
                    case CompareStudentBy.COURSE:
                        np = a.Course.CompareTo(b.Course);
                        break;
                }

                return np;
            }
        }

        public static int CompareStudents(CompareStudentBy by, Student s1, Student s2) {
            return new CompareStudent(by).Compare(s1, s2);
        }

        public static int CompareStudentsByName(Student s1, Student s2) {
            return CompareStudents(CompareStudentBy.NAME, s1, s2);
        }

        public static int CompareStudentsByAge(Student s1, Student s2) {
            return CompareStudents(CompareStudentBy.AGE, s1, s2);
        }

        public static int CompareStudentsByCourse(Student s1, Student s2) {
            return CompareStudents(CompareStudentBy.COURSE, s1, s2);
        }
    }
}