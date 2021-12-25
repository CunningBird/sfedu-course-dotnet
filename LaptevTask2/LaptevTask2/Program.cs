using System;
using System.Collections.Generic;

namespace LaptevTask2 {
    class Program {
        static void Main(string[] args) {
            Teacher t;
            t = new Teacher("Учитель", 30, "Кафедра", null);

            var l = new List<Student>();
            l.Add(new Student("Сидоров", 19, 1, 5));
            l.Add(new Student("Петров", 18, 1, 5));

            t.Students = l;
            t.Print();

            StudentWithAdvisor s = new StudentWithAdvisor("Петров", 18, 1, 5, t);
            int m = 4;
            int n = 3;
            Console.ReadKey();
        }
    }
}