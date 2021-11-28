using System;
using System.Collections.Generic;
using NUnit.Framework;
using PersonLib;
using StudentLib;
using TeacherLib;

namespace Tests
{
    [TestFixture]
    public class TestTask54 {
        [Test]
        public void TestCloneStudent() {
            Student s1 = new Student("Van", 18, 1);
            Student s2 = (Student) s1.Clone();
            Assert.AreEqual(s1, s2);
        }

        [Test]
        public void TestClonePerson() {
            Person p1 = new Person("Van", 18);
            Person p2 = (Person) p1.Clone();
            Assert.AreEqual(p1, p2);
        }

        [Test]
        public void TestCloneTeacher() {
            Student s1 = new Student("Van", 18, 1);
            Teacher t1 = new Teacher("Billy", 33, new List<Student>() {s1});
            Teacher t2 = (Teacher) t1.Clone();
            Assert.AreEqual(t1, t2);
        }
    }
}