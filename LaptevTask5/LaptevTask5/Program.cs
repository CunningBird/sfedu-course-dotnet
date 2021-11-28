using System;
using System.Collections.Generic;
using PersonLib;
using StudentLib;
using TeacherLib;

namespace LaptevTask5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Task5.1
            Person pp = new Person("Van", 33);
            pp.Print();
            Student ss = new Student("Billy", 22, 4);
            ss.Print();
            Teacher tt = new Teacher("John", 70, new List<Student>() {ss});
            tt.Print();
            Console.WriteLine("\n\n");

            //Task5.6
            Student student1 = new Student("Billy", 22, 4);
            Student student2 = new Student("Michael", 20, 3);
            Person person3 = new Person("Van", 22);
            Student student4 = new Student("George", 22, 3);
            Person person5 = new Person("John", 25);

            Persons persons = new Persons();
            persons.Add(student1);
            persons.Add(student2);
            persons.Add(person3);
            persons.Add(student4);
            persons.Add(person5);
            foreach (Person p in persons) { p.Print(); }
            Console.WriteLine("\n\n");

            //Task5.5
            using (Person p = new Person("Jason", 24)) { p.Print(); }

            using (Student s = new Student("Jason", 24, 1)) { s.Print(); }

            using (Teacher t = new Teacher("Jason", 24, new List<Student>() { })) { t.Print(); }
        }
    }
}