using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void String_ShouldEqualIgnoringCasePassTest()
        {
            "test".ShouldEqualIgnoringCase("TeSt");
            "test".ShouldEqualIgnoringCase("test");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void String_ShouldEqualIgnoringCaseFailTest()
        {
            "test".ShouldEqualIgnoringCase("test1");
        }

        [TestMethod]
        public void String_ShouldNotEqualIgnoringCasePassTest()
        {
            "test".ShouldNotEqualIgnoringCase("Test1");
            "".ShouldNotEqualIgnoringCase("test");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void String_ShouldNotEqualIgnoringCaseFailTest()
        {
            "test".ShouldNotEqualIgnoringCase("Test");
        }

        [TestMethod]
        public void String_ShouldBeEmptyPassTest()
        {
            "".ShouldBeEmpty();
            String.Empty.ShouldBeEmpty();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void String_ShouldBeEmptyFailTest()
        {
            "test".ShouldBeEmpty();
        }


        [TestMethod]
        public void String_ShouldNotBeEmptyPassTest()
        {
            "test".ShouldNotBeEmpty();
            ((string)null).ShouldNotBeEmpty();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void String_ShouldNotBeEmptyFailTest()
        {
            "".ShouldNotBeEmpty();   
        }

        [TestMethod]
        public void String_ShouldContainPassTest()
        {
            "test".ShouldContain("es");
            "test".ShouldContain("te");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void String_ShouldContainFailTest()
        {
            "test".ShouldContain("foo");
        }

        [TestMethod]
        public void String_ShouldContainIgnoringCasePassTest()
        {
            "test".ShouldContainIgnoringCase("es");
            "test".ShouldContainIgnoringCase("TE");
            "test".ShouldContainIgnoringCase("eSt");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void String_ShouldContainIgnoringCaseFailTest()
        {
            "test".ShouldContainIgnoringCase("foo");
        }

        [TestMethod]
        public void String_ShouldNotContainPassTest()
        {
            "test".ShouldNotContain("foo");
            "test".ShouldNotContain("TE");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void String_ShouldNotContainFailTest()
        {
            "test".ShouldNotContain("te");
        }

        [TestMethod]
        public void String_ShouldJNotContainIgnoringCasePassTest()
        {
            "test".ShouldNotContainIgnoringCase("foo");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void String_ShouldNotContainIgnoringCaseFailTest()
        {
            "test".ShouldNotContainIgnoringCase("TE");
        }

        [TestMethod]
        public void String_ShouldHaveLengthOfPassTest()
        {
            "test".ShouldHaveLengthOf(4);
            String.Empty.ShouldHaveLengthOf(0);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void String_ShouldHaveLengthOfFailTest()
        {
            "test".ShouldHaveLengthOf(5);
        }

        [TestMethod]
        public void String_ShouldNotHaveLengthOfPassTest()
        {
            "test".ShouldNotHaveLengthOf(3);
            String.Empty.ShouldNotHaveLengthOf(1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void String_ShouldNotHaveLengthOfFailTest()
        {
            "test".ShouldNotHaveLengthOf(4);
        }

        [TestMethod]
        public void String_ShouldHaveLengthOfAtLeastPassTest()
        {
            "test".ShouldHaveLengthOfAtLeast(3);
            String.Empty.ShouldHaveLengthOfAtLeast(0);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void String_ShouldHaveLengthOfAtLeastFailTest()
        {
            "test".ShouldHaveLengthOfAtLeast(5);
        }

        [TestMethod]
        public void String_ShouldHaveLengthOfAtMostPassTest()
        {
            "test".ShouldHaveLengthOfAtMost(5);
            String.Empty.ShouldHaveLengthOfAtMost(2);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void String_ShouldHaveLengthOfAtMostFailTest()
        {
            "test".ShouldHaveLengthOfAtMost(3);
        }
    }
}
