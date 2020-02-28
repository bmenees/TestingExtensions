using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class UInteger16ExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void UShort_ShouldBeGreaterThanPassTest()
        {
            ((ushort)0x01).ShouldBeGreaterThan(0x00);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UShort_ShouldBeGreaterThanFailTest()
        {
            ((ushort)0x44).ShouldBeGreaterThan(0x45);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UShort_ShouldBeGreaterThanFailWhereEqualTest()
        {
            ((ushort)0x44).ShouldBeGreaterThan(0x44);
        }

        [TestMethod]
        public void UShort_ShouldBeGreaterThanOrEqualToPassTest()
        {
            ((ushort)0x01).ShouldBeGreaterThanOrEqualTo(0x00);
            ((ushort)0x01).ShouldBeGreaterThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UShort_ShouldBeGreaterThanOrEqualToFailTest()
        {
            ((ushort)0x44).ShouldBeGreaterThanOrEqualTo(0x45);
        }

        [TestMethod]
        public void UShort_ShouldBeLessThanPassTest()
        {
            ((ushort)0x01).ShouldBeLessThan(0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UShort_ShouldBeLessThanFailTest()
        {
            ((ushort)0x44).ShouldBeLessThan(0x43);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UShort_ShouldBeLessThanFailWhereEqualTest()
        {
            ((ushort)0x44).ShouldBeLessThan(0x44);
        }

        [TestMethod]
        public void UShort_ShouldBeLessThanOrEqualToPassTest()
        {
            ((ushort)0x01).ShouldBeLessThanOrEqualTo(0x02);
            ((ushort)0x01).ShouldBeLessThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UShort_ShouldBeLessThanOrEqualToFailTest()
        {
            ((ushort)0x44).ShouldBeLessThanOrEqualTo(0x43);
        }

        [TestMethod]
        public void UShort_ShouldBeBetweenPassTest()
        {
            ((ushort)0x01).ShouldBeBetween(0x00, 0x05);
            ((ushort)0x01).ShouldBeBetween(0x01, 0x05);
            ((ushort)0x01).ShouldBeBetween(0x01, 0x05);
            ((ushort)0x05).ShouldBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UShort_ShouldBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((ushort)0x05).ShouldBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UShort_ShouldBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((ushort)0x05).ShouldBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UShort_ShouldBeBetweenFailWhereLessThanLowerTest()
        {
            ((ushort)0x01).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UShort_ShouldBeBetweenFailWhereGreaterThanUpperTest()
        {
            ((ushort)0x06).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void UShort_ShouldNotBeBetweenPassTest()
        {
            ((ushort)0x06).ShouldNotBeBetween(0x00, 0x05);
            ((ushort)0x00).ShouldNotBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UShort_ShouldNotBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((ushort)0x05).ShouldNotBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UShort_ShouldNotBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((ushort)0x05).ShouldNotBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UShort_ShouldNotBeBetweenFailTest()
        {
            ((ushort)0x04).ShouldNotBeBetween(0x02, 0x05);
        }
    }
}
