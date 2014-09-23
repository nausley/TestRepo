using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NPLoggerSample;

namespace UnitTest
{
    [TestFixture]
    public class UnitTestLogger
    {
        private Sample1 _sample1;

        [SetUp]
        public void SetUp()
        {
            _sample1 = new Sample1();
        }

        [TearDown]
        public void TearDown()
        {
            _sample1 = null;
        }

        [Test]
        public void LogTestExecute()
        {
            _sample1.LogTest();

            Assert.Pass();

        }

        [Test]
        public void LogDebugSession()
        {
            _sample1.DebugSession();
            Assert.Pass();
        }


        [Test]
        public void LogImbeddedCalls()
        {
            _sample1.LogTestImbedded();
            Assert.Pass();
        }

        [Test]
        public void MultiSession()
        {
            _sample1.LogTest();
            _sample1.DebugSession();
            Assert.Pass();
        }


        [Test]
        public void PossibleExcpetion()
        {
            //_sample1.PossibleException(10, 5);
            _sample1.PossibleException(5, 10);
            _sample1.PossibleException(2, 0);
            Assert.Pass();
        }

        [Test]
        public void ObjectTest()
        {
            _sample1.Objects();
            Assert.Pass();
        }

        [Test]
        public void ObjectListTest()
        {
            _sample1.ListObjects();
            Assert.Pass();
        }

        [Test]
        public void ListUIDTest()
        {
            _sample1.ListUIDs();
            Assert.Pass();
        }

        [Test]
        public void MongoObjectsTest()
        {
            _sample1.MongoObjects();
            Assert.Pass();
        }
    }
}
