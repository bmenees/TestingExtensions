using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class Integer64ExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Long_ShouldBeGreaterThanPassTest()
        {
            ((long)0x01).ShouldBeGreaterThan(0x00);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Long_ShouldBeGreaterThanFailTest()
        {
            ((long)0x44).ShouldBeGreaterThan(0x45);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Long_ShouldBeGreaterThanFailWhereEqualTest()
        {
            ((long)0x44).ShouldBeGreaterThan(0x44);
        }

        [TestMethod]
        public void Long_ShouldBeGreaterThanOrEqualToPassTest()
        {
            ((long)0x01).ShouldBeGreaterThanOrEqualTo(0x00);
            ((long)0x01).ShouldBeGreaterThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Long_ShouldBeGreaterThanOrEqualToFailTest()
        {
            ((long)0x44).ShouldBeGreaterThanOrEqualTo(0x45);
        }

        [TestMethod]
        public void Long_ShouldBeLessThanPassTest()
        {
            ((long)0x01).ShouldBeLessThan(0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Long_ShouldBeLessThanFailTest()
        {
            ((long)0x44).ShouldBeLessThan(0x43);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Long_ShouldBeLessThanFailWhereEqualTest()
        {
            ((long)0x44).ShouldBeLessThan(0x44);
        }

        [TestMethod]
        public void Long_ShouldBeLessThanOrEqualToPassTest()
        {
            ((long)0x01).ShouldBeLessThanOrEqualTo(0x02);
            ((long)0x01).ShouldBeLessThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Long_ShouldBeLessThanOrEqualToFailTest()
        {
            ((long)0x44).ShouldBeLessThanOrEqualTo(0x43);
        }

        [TestMethod]
        public void Long_ShouldBeBetweenPassTest()
        {
            ((long)0x01).ShouldBeBetween(0x00, 0x05);
            ((long)0x01).ShouldBeBetween(0x01, 0x05);
            ((long)0x01).ShouldBeBetween(0x01, 0x05);
            ((long)0x05).ShouldBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Long_ShouldBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((long)0x05).ShouldBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Long_ShouldBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((long)0x05).ShouldBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Long_ShouldBeBetweenFailWhereLessThanLowerTest()
        {
            ((long)0x01).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Long_ShouldBeBetweenFailWhereGreaterThanUpperTest()
        {
            ((long)0x06).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void Long_ShouldNotBeBetweenPassTest()
        {
            ((long)0x06).ShouldNotBeBetween(0x00, 0x05);
            ((long)0x00).ShouldNotBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Long_ShouldNotBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((long)0x05).ShouldNotBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Long_ShouldNotBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((long)0x05).ShouldNotBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Long_ShouldNotBeBetweenFailTest()
        {
            ((long)0x04).ShouldNotBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void Long_ShouldBePositivePassTest()
        {
            ((long)3).ShouldBePositive();
            ((long)0).ShouldBePositive();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Long_ShouldBePositiveFailTest()
        {
            ((long)-2).ShouldBePositive();
        }

        [TestMethod]
        public void Long_ShouldBeNegativePassTest()
        {
            ((long)-3).ShouldBeNegative();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Long_ShouldBeNegativeFailTest()
        {
            ((long)2).ShouldBeNegative();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Long_ShouldBeNegativeFailWhereZeroTest()
        {
            ((long)0).ShouldBeNegative();
        }
    }
}
