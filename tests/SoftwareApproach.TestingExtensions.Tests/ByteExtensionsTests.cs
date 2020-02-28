using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class ByteExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Byte_ShouldBeGreaterThanPassTest()
        {
            ((byte)0x01).ShouldBeGreaterThan(0x00);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Byte_ShouldBeGreaterThanFailTest()
        {
            ((byte)0x44).ShouldBeGreaterThan(0x45);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Byte_ShouldBeGreaterThanFailWhereEqualTest()
        {
            ((byte)0x44).ShouldBeGreaterThan(0x44);
        }

        [TestMethod]
        public void Byte_ShouldBeGreaterThanOrEqualToPassTest()
        {
            ((byte)0x01).ShouldBeGreaterThanOrEqualTo(0x00);
            ((byte)0x01).ShouldBeGreaterThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Byte_ShouldBeGreaterThanOrEqualToFailTest()
        {
            ((byte)0x44).ShouldBeGreaterThanOrEqualTo(0x45);
        }

        [TestMethod]
        public void Byte_ShouldBeLessThanPassTest()
        {
            ((byte)0x01).ShouldBeLessThan(0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Byte_ShouldBeLessThanFailTest()
        {
            ((byte)0x44).ShouldBeLessThan(0x43);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Byte_ShouldBeLessThanFailWhereEqualTest()
        {
            ((byte)0x44).ShouldBeLessThan(0x44);
        }

        [TestMethod]
        public void Byte_ShouldBeLessThanOrEqualToPassTest()
        {
            ((byte)0x01).ShouldBeLessThanOrEqualTo(0x02);
            ((byte)0x01).ShouldBeLessThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Byte_ShouldBeLessThanOrEqualToFailTest()
        {
            ((byte)0x44).ShouldBeLessThanOrEqualTo(0x43);
        }

        [TestMethod]
        public void Byte_ShouldBeBetweenPassTest()
        {
            ((byte)0x01).ShouldBeBetween(0x00, 0x05);
            ((byte)0x01).ShouldBeBetween(0x01, 0x05);
            ((byte)0x01).ShouldBeBetween(0x01, 0x05);
            ((byte)0x05).ShouldBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Byte_ShouldBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((byte)0x05).ShouldBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Byte_ShouldBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((byte)0x05).ShouldBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Byte_ShouldBeBetweenFailWhereLessThanLowerTest()
        {
            ((byte)0x01).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Byte_ShouldBeBetweenFailWhereGreaterThanUpperTest()
        {
            ((byte)0x06).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void Byte_ShouldNotBeBetweenPassTest()
        {
            ((byte)0x06).ShouldNotBeBetween(0x00, 0x05);
            ((byte)0x00).ShouldNotBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Byte_ShouldNotBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((byte)0x05).ShouldNotBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Byte_ShouldNotBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((byte)0x05).ShouldNotBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Byte_ShouldNotBeBetweenFailTest()
        {
            ((byte)0x04).ShouldNotBeBetween(0x02, 0x05);
        }
    }
}
