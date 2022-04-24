using NUnit.Framework;
using UnitTestAndDebug;
//using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing
{
    [TestFixture]
    public class PersonNameTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ValidName()
        {
            
            Person personWithValidName = new Person ("Sergio Rochet", "1.234.564-8");
            
            Assert.AreEqual(personWithValidName.Name, "Sergio Rochet");
            
        }

        [Test]
        public void InvalidNullName()
        {
            
            Person personWithNullName = new Person (null, "1.234.564");
           
            Assert.IsNull(personWithNullName.Name);
            
        }

        [Test]
        public void InvalidEmptyName()
        {
            
            Person personWithEmptyName = new Person ("", "1.234.564");
            Assert.IsNotEmpty(personWithEmptyName.Name);
            
        }
    }
}