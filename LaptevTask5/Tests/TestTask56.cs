using NUnit.Framework;
using PersonLib;
using StudentLib;

namespace Tests
{
    [TestFixture]
    public class TestTask56
    {
        [Test]
        public void TestEnumerable()
        {
            Student s1 = new Student("Van", 18, 1);
            Student s2 = new Student("Billy", 20, 4);
            Person p1 = new Person("John", 24);
            Person p2 = new Person("Michael", 23);
            
            Persons persons = new Persons();
            persons.Add(p1);
            persons.Add(s1);
            persons.Add(p2);
            persons.Add(s2);

            int index = 0;
            foreach (Person p in persons) {
                if (index == 0) { Assert.AreEqual(p, p1); }
                if (index == 1) { Assert.AreEqual(p, s1); }
                if (index == 2) { Assert.AreEqual(p, p2); }
                if (index == 3) { Assert.AreEqual(p, s2); }
                index++;
            }

            Assert.AreEqual(4, index);
        }
    }
}