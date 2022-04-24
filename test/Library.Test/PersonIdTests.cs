using NUnit.Framework;
using UnitTestAndDebug;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
    [TestFixture]
    public class PersonIdTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ValidId()
        {
            Assert.AreEqual(true, IdUtils.IdIsValid("5242903-0"));
        }

        [Test]
        public void InvalidId()
        {
            Assert.AreEqual(false, IdUtils.IdIsValid("1.234.564"));
        }

        [Test]
        public void InvalidId2()
        {
            Assert.AreEqual(false, IdUtils.IdIsValid("abcde"));
        }
    }
}