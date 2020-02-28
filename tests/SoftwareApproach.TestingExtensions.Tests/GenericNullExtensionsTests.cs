using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class GenericNullExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Object_ShouldBeNullPassTest()
        {
            ((bool?)null).ShouldBeNull();
            ((string)null).ShouldBeNull();
            ((object)null).ShouldBeNull();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Object_ShouldBeNullFailTest()
        {
            ((string)"test").ShouldBeNull();
        }

        [TestMethod]
        public void Object_ShouldNotBeNullPassTest()
        {
            ((int)0).ShouldNotBeNull();
            ((int?)1).ShouldNotBeNull();
            ((string)"test").ShouldNotBeNull();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Object_ShouldNotBeNullFailTest()
        {
            ((object)null).ShouldNotBeNull();
        }
    }
}
