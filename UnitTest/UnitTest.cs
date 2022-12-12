using Library;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddEmployee()
        {
            Department r = new Department("Developer", 3, new Developer("Head", "", ""));

            Assert.IsTrue(r.AddEmployee(new Developer("n1", "l1", "c#")));
            Assert.IsTrue(r.AddEmployee(new Developer("n2", "l2", "vb.net")));
            Assert.IsTrue(r.AddEmployee(new Developer("n3", "l3", "Java")));
            Assert.IsFalse(r.AddEmployee(new Developer("n4", "l4", "Python")));
        }
    }
}