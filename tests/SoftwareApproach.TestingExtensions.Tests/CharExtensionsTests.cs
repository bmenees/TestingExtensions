using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class CharExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Char_ShouldBeGreaterThanPassTest()
        {
            ('a').ShouldBeGreaterThan('Z');
            ('z').ShouldBeGreaterThan('a');
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldBeGreaterThanFailTest()
        {
            ('A').ShouldBeGreaterThan('B');
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldBeGreaterThanFailWhereEqualTest()
        {
            ('A').ShouldBeGreaterThan('A');
        }

        [TestMethod]
        public void Char_ShouldBeGreaterThanOrEqualToPassTest()
        {
            ('B').ShouldBeGreaterThanOrEqualTo('A');
            ('B').ShouldBeGreaterThanOrEqualTo('B');
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldBeGreaterThanOrEqualToFailTest()
        {
            ('A').ShouldBeGreaterThanOrEqualTo('B');
        }

        [TestMethod]
        public void Char_ShouldBeLessThanPassTest()
        {
            ('Z').ShouldBeLessThan('a');
            ('a').ShouldBeLessThan('z');
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldBeLessThanFailTest()
        {
            ('B').ShouldBeLessThan('A');
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldBeLessThanFailWhereEqualTest()
        {
            ('A').ShouldBeLessThan('A');
        }

        [TestMethod]
        public void Char_ShouldBeLessThanOrEqualToPassTest()
        {
            ('B').ShouldBeLessThanOrEqualTo('C');
            ('B').ShouldBeLessThanOrEqualTo('B');
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldBeLessThanOrEqualToFailTest()
        {
            ('B').ShouldBeLessThanOrEqualTo('A');
        }

        [TestMethod]
        public void Char_ShouldBeBetweenPassTest()
        {
            ('B').ShouldBeBetween('A', 'E');
            ('A').ShouldBeBetween('A', 'E');
            ('D').ShouldBeBetween('A', 'E');
            ('E').ShouldBeBetween('A', 'E');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Char_ShouldBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ('B').ShouldBeBetween('B', 'A');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Char_ShouldBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ('B').ShouldBeBetween('B', 'B');
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldBeBetweenFailWhereLessThanLowerTest()
        {
            ('A').ShouldBeBetween('B', 'E');
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldBeBetweenFailWhereGreaterThanUpperTest()
        {
            ('F').ShouldBeBetween('B', 'E');
        }

        [TestMethod]
        public void Char_ShouldNotBeBetweenPassTest()
        {
            ('B').ShouldNotBeBetween('C', 'F');
            ('G').ShouldNotBeBetween('C', 'F');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Char_ShouldNotBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ('G').ShouldNotBeBetween('C', 'B');
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Char_ShouldNotBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ('G').ShouldNotBeBetween('C', 'C');
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldNotBeBetweenFailTest()
        {
            ('E').ShouldNotBeBetween('C', 'F');
        }

        [TestMethod]
        public void Char_ShouldEqualIgnoringCasePassTest()
        {
            ('a').ShouldEqualIgnoringCase('A');
            ('A').ShouldEqualIgnoringCase('a');
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldEqualIgnoringCaseFailTest()
        {
            ('a').ShouldEqualIgnoringCase('B');
        }

        [TestMethod]
        public void Char_ShouldNotEqualIgnoringCasePassTest()
        {
            ('a').ShouldNotEqualIgnoringCase('B');
            ('A').ShouldNotEqualIgnoringCase('b');
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldNotEqualIgnoringCaseFailTest()
        {
            ('a').ShouldNotEqualIgnoringCase('A');
        }

        [TestMethod]
        public void Char_ShouldBePrintablePassTest()
        {
            ('a').ShouldBePrintable();
            (' ').ShouldBePrintable();
            ('/').ShouldBePrintable();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldBePrintableFailTest()
        {
            ('\t').ShouldBePrintable();
        }

        [TestMethod]
        public void Char_ShouldNotBePrintablePassTest()
        {
            ((char)2).ShouldNotBePrintable();
            ((char)140).ShouldNotBePrintable();
            ('\t').ShouldNotBePrintable();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Char_ShouldNotBePrintableFailTest()
        {
            ('a').ShouldNotBePrintable();
        }
    }
}
