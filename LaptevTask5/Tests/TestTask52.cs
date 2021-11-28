using System;
using NUnit.Framework;
using StudentLib;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class TestTask52 {
        
        [Test]
        public void TestCompare() {
            Student student1 = new Student("Billy", 22, 4);
            Student student2 = new Student("Michael", 20, 3);
            Student student22 = new Student("Van", 22, 3);
            Student student222 = new Student("George", 22, 3);
            Student student3 = new Student("John", 25, 1);

            List<Student> testStudents = new List<Student>() {student1, student2, student22, student222, student3,};
            List<Student> sortedStudents = new List<Student>() {student3, student2, student222, student22, student1};
            testStudents.Sort(((s1, s2) => s1.CompareTo(s2)));
            Assert.AreEqual(sortedStudents, testStudents);
        }

        [Test]
        public void TestCompareNotEqual() {
            Student student1 = new Student("Billy", 22, 4);
            Student student2 = new Student("Michael", 20, 3);
            Student student22 = new Student("Van", 22, 3);
            Student student222 = new Student("George", 22, 3);
            Student student3 = new Student("John", 25, 1);

            List<Student> testStudents = new List<Student>() {student1, student2, student22, student222, student3,};
            List<Student> sortedStudents = new List<Student>() {student3, student2, student222, student1, student22};
            testStudents.Sort(((s1, s2) => s1.CompareTo(s2)));
            Assert.AreNotEqual(sortedStudents, testStudents);
        }
    }
}