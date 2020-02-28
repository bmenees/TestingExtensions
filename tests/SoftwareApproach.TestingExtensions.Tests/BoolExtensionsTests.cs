using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class BoolExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Bool_ShouldBeFalsePassTest()
        {
            false.ShouldBeFalse();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Bool_ShouldBeFalseFailTest()
        {
            true.ShouldBeFalse();
        }

        [TestMethod]
        public void Bool_ShouldBeFalseNullablePassTest()
        {
            ((bool?)false).ShouldBeFalse();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Bool_ShouldBeFalseNullableFailTest()
        {
            ((bool?)true).ShouldBeFalse();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Bool_ShouldBeFalseNullableFailWhereNullTest()
        {
            ((bool?)null).ShouldBeFalse();
        }

        [TestMethod]
        public void Bool_ShouldBeTruePassTest()
        {
            true.ShouldBeTrue();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Bool_ShouldBeTrueFailTest()
        {
            false.ShouldBeTrue();
        }


        [TestMethod]
        public void Bool_ShouldBeTrueNullablePassTest()
        {
            ((bool?)true).ShouldBeTrue();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Bool_ShouldBeTrueNullableFailTest()
        {
            ((bool?)false).ShouldBeTrue();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Bool_ShouldBeTrueNullableFailWhereNullTest()
        {
            ((bool?)null).ShouldBeTrue();
        }
    }
}
