using System.Collections.Generic;
using NUnit.Framework;
using PersonLib;
using StudentLib;
using TeacherLib;

namespace Tests
{
    [TestFixture]
    public class TestTask53 {
        
        [Test]
        public void TestSortByName() {
            Student student1 = new Student("Billy", 22, 4);
            Student student2 = new Student("Michael", 20, 3);
            Student student22 = new Student("Van", 22, 3);
            Student student222 = new Student("George", 22, 3);
            Student student3 = new Student("John", 25, 1);
            
            List<Student> students = new List<Student>() {student1, student2, student3, student22, student222};
            List<Student> stud1 = new List<Student>() {student1, student2, student3, student22, student222};

            students.Sort(((s1, s2) => Student.CompareStudentsByName(s1, s2)));
            List<Student> studentsSorted = new List<Student>() {student1, student222, student3, student2, student22};
            Assert.AreEqual(students, studentsSorted);
            Assert.AreNotEqual(students, stud1);
        }

        [Test]
        public void TestSortByAge() {
            Student student1 = new Student("Billy", 22, 4);
            Student student2 = new Student("Michael", 20, 3);
            Student student22 = new Student("Van", 22, 3);
            Student student222 = new Student("George", 22, 3);
            Student student3 = new Student("John", 25, 1);

            List<Student> students = new List<Student>() {student1, student2, student3, student22, student222};
            List<Student> stud1 = new List<Student>() {student1, student2, student3, student22, student222};
            students.Sort(((s1, s2) => Student.CompareStudentsByAge(s1, s2)));
            List<Student> studentsSorted = new List<Student>() {student2, student1, student222, student22, student3};
            Assert.AreEqual(students, studentsSorted);
            Assert.AreNotEqual(students, stud1);
        }

        [Test]
        public void TestSortByCourse() {
            Student student2 = new Student("Michael", 20, 4);
            Student student22 = new Student("Van", 24, 3);
            Student student222 = new Student("George", 23, 2);
            Student student3 = new Student("John", 25, 1);

            List<Student> students = new List<Student>() {student2, student22, student222, student3};
            List<Student> stud1 = new List<Student>() {student2, student22, student222, student3};
            students.Sort(((s1, s2) => Student.CompareStudentsByCourse(s1, s2)));
            List<Student> studentsSorted = new List<Student>() {student3, student222, student22, student2};
            Assert.AreEqual(students, studentsSorted);
            Assert.AreNotEqual(students, stud1);
        }
    }
}