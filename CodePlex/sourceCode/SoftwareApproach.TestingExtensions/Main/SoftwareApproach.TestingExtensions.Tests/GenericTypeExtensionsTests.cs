using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class GenericTypeExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Object_ShouldBeOfTypePassTest()
        {
            false.ShouldBeOfType(typeof(bool));
            "test".ShouldBeOfType(typeof(string));
            ((int)4).ShouldBeOfType(typeof(int));
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Object_ShouldBeOfTypeFailTest()
        {
            ((int)4).ShouldBeOfType(typeof(bool));
        }

        [TestMethod]
        public void Object_ShouldNotBeOfTypePassTest()
        {
            false.ShouldNotBeOfType(typeof(int));
            "test".ShouldNotBeOfType(typeof(bool));
            ((int)4).ShouldNotBeOfType(typeof(short));
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Object_ShouldNotBeOfTypeFailTest()
        {
            ((int)4).ShouldNotBeOfType(typeof(int));
        }
    }
}
