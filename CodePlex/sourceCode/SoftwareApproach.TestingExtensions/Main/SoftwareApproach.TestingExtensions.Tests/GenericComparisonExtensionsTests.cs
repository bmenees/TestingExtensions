using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class GenericComparisonExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Object_ShouldEqualPassTest()
        {
            ((bool)true).ShouldEqual(((bool)true));
            ((string)"test").ShouldEqual(((string)"test"));
            ((object)null).ShouldEqual(((object)null));
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Object_ShouldEqualFailTest()
        {
            ((string)"test").ShouldEqual((string)"tester");
        }

        [TestMethod]
        public void Object_ShouldNotEqualPassTest()
        {
            ((bool)true).ShouldNotEqual(((bool)false));
            ((string)"test").ShouldNotEqual(((string)"tester"));
            ((object)null).ShouldNotEqual(((int)1));
            ((int)2).ShouldNotEqual(((int)1));
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Object_ShouldNotEqualFailTest()
        {
            ((int)0).ShouldNotEqual((int)0);
        }

        [TestMethod]
        public void Object_ShouldBeSameAsPassTest()
        {
            int i = 4;
            object firstObject = i;
            object secondObject = firstObject;

            firstObject.ShouldBeSameAs(secondObject);
            ((string)"test").ShouldBeSameAs(((string)"test"));
            ((object)null).ShouldBeSameAs(((object)null));
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Object_ShouldBeSameAsFailTest()
        {
            int i = 4;
            object firstObject = i;
            object secondObject = i;

            firstObject.ShouldBeSameAs(secondObject);
        }

        [TestMethod]
        public void Object_ShouldNotBeSameAsPassTest()
        {
            int i = 4;
            object firstObject = i;
            object secondObject = i;

            firstObject.ShouldNotBeSameAs(secondObject);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Object_ShouldNotBeSameAsFailTest()
        {
            int i = 10;
            object firstObject = i;
            object secondObject = firstObject;

            firstObject.ShouldNotBeSameAs(secondObject);
        }
    }
}
