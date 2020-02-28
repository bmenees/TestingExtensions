using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class Integer16ExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Short_ShouldBeGreaterThanPassTest()
        {
            ((short)0x01).ShouldBeGreaterThan(0x00);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Short_ShouldBeGreaterThanFailTest()
        {
            ((short)0x44).ShouldBeGreaterThan(0x45);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Short_ShouldBeGreaterThanFailWhereEqualTest()
        {
            ((short)0x44).ShouldBeGreaterThan(0x44);
        }

        [TestMethod]
        public void Short_ShouldBeGreaterThanOrEqualToPassTest()
        {
            ((short)0x01).ShouldBeGreaterThanOrEqualTo(0x00);
            ((short)0x01).ShouldBeGreaterThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Short_ShouldBeGreaterThanOrEqualToFailTest()
        {
            ((short)0x44).ShouldBeGreaterThanOrEqualTo(0x45);
        }

        [TestMethod]
        public void Short_ShouldBeLessThanPassTest()
        {
            ((short)0x01).ShouldBeLessThan(0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Short_ShouldBeLessThanFailTest()
        {
            ((short)0x44).ShouldBeLessThan(0x43);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Short_ShouldBeLessThanFailWhereEqualTest()
        {
            ((short)0x44).ShouldBeLessThan(0x44);
        }

        [TestMethod]
        public void Short_ShouldBeLessThanOrEqualToPassTest()
        {
            ((short)0x01).ShouldBeLessThanOrEqualTo(0x02);
            ((short)0x01).ShouldBeLessThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Short_ShouldBeLessThanOrEqualToFailTest()
        {
            ((short)0x44).ShouldBeLessThanOrEqualTo(0x43);
        }

        [TestMethod]
        public void Short_ShouldBeBetweenPassTest()
        {
            ((short)0x01).ShouldBeBetween(0x00, 0x05);
            ((short)0x01).ShouldBeBetween(0x01, 0x05);
            ((short)0x01).ShouldBeBetween(0x01, 0x05);
            ((short)0x05).ShouldBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Short_ShouldBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((short)0x05).ShouldBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Short_ShouldBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((short)0x05).ShouldBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Short_ShouldBeBetweenFailWhereLessThanLowerTest()
        {
            ((short)0x01).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Short_ShouldBeBetweenFailWhereGreaterThanUpperTest()
        {
            ((short)0x06).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void Short_ShouldNotBeBetweenPassTest()
        {
            ((short)0x06).ShouldNotBeBetween(0x00, 0x05);
            ((short)0x00).ShouldNotBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Short_ShouldNotBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((short)0x05).ShouldNotBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Short_ShouldNotBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((short)0x05).ShouldNotBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Short_ShouldNotBeBetweenFailTest()
        {
            ((short)0x04).ShouldNotBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void Short_ShouldBePositivePassTest()
        {
            ((short)3).ShouldBePositive();
            ((short)0).ShouldBePositive();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Short_ShouldBePositiveFailTest()
        {
            ((short)-2).ShouldBePositive();
        }

        [TestMethod]
        public void Short_ShouldBeNegativePassTest()
        {
            ((short)-3).ShouldBeNegative();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Short_ShouldBeNegativeFailTest()
        {
            ((short)2).ShouldBeNegative();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Short_ShouldBeNegativeFailWhereZeroTest()
        {
            ((short)0).ShouldBeNegative();
        }
    }
}
