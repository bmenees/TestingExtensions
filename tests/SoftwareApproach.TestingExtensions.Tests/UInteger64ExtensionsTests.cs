using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class UInteger64ExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void ULong_ShouldBeGreaterThanPassTest()
        {
            ((ulong)0x01).ShouldBeGreaterThan(0x00);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ULong_ShouldBeGreaterThanFailTest()
        {
            ((ulong)0x44).ShouldBeGreaterThan(0x45);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ULong_ShouldBeGreaterThanFailWhereEqualTest()
        {
            ((ulong)0x44).ShouldBeGreaterThan(0x44);
        }

        [TestMethod]
        public void ULong_ShouldBeGreaterThanOrEqualToPassTest()
        {
            ((ulong)0x01).ShouldBeGreaterThanOrEqualTo(0x00);
            ((ulong)0x01).ShouldBeGreaterThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ULong_ShouldBeGreaterThanOrEqualToFailTest()
        {
            ((ulong)0x44).ShouldBeGreaterThanOrEqualTo(0x45);
        }

        [TestMethod]
        public void ULong_ShouldBeLessThanPassTest()
        {
            ((ulong)0x01).ShouldBeLessThan(0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ULong_ShouldBeLessThanFailTest()
        {
            ((ulong)0x44).ShouldBeLessThan(0x43);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ULong_ShouldBeLessThanFailWhereEqualTest()
        {
            ((ulong)0x44).ShouldBeLessThan(0x44);
        }

        [TestMethod]
        public void ULong_ShouldBeLessThanOrEqualToPassTest()
        {
            ((ulong)0x01).ShouldBeLessThanOrEqualTo(0x02);
            ((ulong)0x01).ShouldBeLessThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ULong_ShouldBeLessThanOrEqualToFailTest()
        {
            ((ulong)0x44).ShouldBeLessThanOrEqualTo(0x43);
        }

        [TestMethod]
        public void ULong_ShouldBeBetweenPassTest()
        {
            ((ulong)0x01).ShouldBeBetween(0x00, 0x05);
            ((ulong)0x01).ShouldBeBetween(0x01, 0x05);
            ((ulong)0x01).ShouldBeBetween(0x01, 0x05);
            ((ulong)0x05).ShouldBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ULong_ShouldBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((ulong)0x05).ShouldBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ULong_ShouldBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((ulong)0x05).ShouldBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ULong_ShouldBeBetweenFailWhereLessThanLowerTest()
        {
            ((ulong)0x01).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ULong_ShouldBeBetweenFailWhereGreaterThanUpperTest()
        {
            ((ulong)0x06).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void ULong_ShouldNotBeBetweenPassTest()
        {
            ((ulong)0x06).ShouldNotBeBetween(0x00, 0x05);
            ((ulong)0x00).ShouldNotBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ULong_ShouldNotBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((ulong)0x05).ShouldNotBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ULong_ShouldNotBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((ulong)0x05).ShouldNotBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ULong_ShouldNotBeBetweenFailTest()
        {
            ((ulong)0x04).ShouldNotBeBetween(0x02, 0x05);
        }
    }
}
