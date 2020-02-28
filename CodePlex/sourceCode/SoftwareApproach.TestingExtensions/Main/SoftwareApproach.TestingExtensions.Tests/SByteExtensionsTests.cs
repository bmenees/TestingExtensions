using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class SByteExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void SByte_ShouldBeGreaterThanPassTest()
        {
            ((sbyte)0x01).ShouldBeGreaterThan(0x00);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void SByte_ShouldBeGreaterThanFailTest()
        {
            ((sbyte)0x44).ShouldBeGreaterThan(0x45);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void SByte_ShouldBeGreaterThanFailWhereEqualTest()
        {
            ((sbyte)0x44).ShouldBeGreaterThan(0x44);
        }

        [TestMethod]
        public void SByte_ShouldBeGreaterThanOrEqualToPassTest()
        {
            ((sbyte)0x01).ShouldBeGreaterThanOrEqualTo(0x00);
            ((sbyte)0x01).ShouldBeGreaterThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void SByte_ShouldBeGreaterThanOrEqualToFailTest()
        {
            ((sbyte)0x44).ShouldBeGreaterThanOrEqualTo(0x45);
        }

        [TestMethod]
        public void SByte_ShouldBeLessThanPassTest()
        {
            ((sbyte)0x01).ShouldBeLessThan(0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void SByte_ShouldBeLessThanFailTest()
        {
            ((sbyte)0x44).ShouldBeLessThan(0x43);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void SByte_ShouldBeLessThanFailWhereEqualTest()
        {
            ((sbyte)0x44).ShouldBeLessThan(0x44);
        }

        [TestMethod]
        public void SByte_ShouldBeLessThanOrEqualToPassTest()
        {
            ((sbyte)0x01).ShouldBeLessThanOrEqualTo(0x02);
            ((sbyte)0x01).ShouldBeLessThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void SByte_ShouldBeLessThanOrEqualToFailTest()
        {
            ((sbyte)0x44).ShouldBeLessThanOrEqualTo(0x43);
        }

        [TestMethod]
        public void SByte_ShouldBeBetweenPassTest()
        {
            ((sbyte)0x01).ShouldBeBetween(0x00, 0x05);
            ((sbyte)0x01).ShouldBeBetween(0x01, 0x05);
            ((sbyte)0x01).ShouldBeBetween(0x01, 0x05);
            ((sbyte)0x05).ShouldBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SByte_ShouldBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((sbyte)0x05).ShouldBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SByte_ShouldBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((sbyte)0x05).ShouldBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void SByte_ShouldBeBetweenFailWhereLessThanLowerTest()
        {
            ((sbyte)0x01).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void SByte_ShouldBeBetweenFailWhereGreaterThanUpperTest()
        {
            ((sbyte)0x06).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void SByte_ShouldNotBeBetweenPassTest()
        {
            ((sbyte)0x06).ShouldNotBeBetween(0x00, 0x05);
            ((sbyte)0x00).ShouldNotBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SByte_ShouldNotBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((sbyte)0x05).ShouldNotBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SByte_ShouldNotBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((sbyte)0x05).ShouldNotBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void SByte_ShouldNotBeBetweenFailTest()
        {
            ((sbyte)0x04).ShouldNotBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void SByte_ShouldBePositivePassTest()
        {
            ((sbyte)3).ShouldBePositive();
            ((sbyte)0).ShouldBePositive();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void SByte_ShouldBePositiveFailTest()
        {
            ((sbyte)-2).ShouldBePositive();
        }

        [TestMethod]
        public void SByte_ShouldBeNegativePassTest()
        {
            ((sbyte)-3).ShouldBeNegative();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void SByte_ShouldBeNegativeFailTest()
        {
            ((sbyte)2).ShouldBeNegative();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void SByte_ShouldBeNegativeFailWhereZeroTest()
        {
            ((sbyte)0).ShouldBeNegative();
        }
    }
}
