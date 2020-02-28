using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class UInteger32ExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void UInt_ShouldBeGreaterThanPassTest()
        {
            ((uint)0x01).ShouldBeGreaterThan(0x00);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UInt_ShouldBeGreaterThanFailTest()
        {
            ((uint)0x44).ShouldBeGreaterThan(0x45);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UInt_ShouldBeGreaterThanFailWhereEqualTest()
        {
            ((uint)0x44).ShouldBeGreaterThan(0x44);
        }

        [TestMethod]
        public void UInt_ShouldBeGreaterThanOrEqualToPassTest()
        {
            ((uint)0x01).ShouldBeGreaterThanOrEqualTo(0x00);
            ((uint)0x01).ShouldBeGreaterThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UInt_ShouldBeGreaterThanOrEqualToFailTest()
        {
            ((uint)0x44).ShouldBeGreaterThanOrEqualTo(0x45);
        }

        [TestMethod]
        public void UInt_ShouldBeLessThanPassTest()
        {
            ((uint)0x01).ShouldBeLessThan(0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UInt_ShouldBeLessThanFailTest()
        {
            ((uint)0x44).ShouldBeLessThan(0x43);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UInt_ShouldBeLessThanFailWhereEqualTest()
        {
            ((uint)0x44).ShouldBeLessThan(0x44);
        }

        [TestMethod]
        public void UInt_ShouldBeLessThanOrEqualToPassTest()
        {
            ((uint)0x01).ShouldBeLessThanOrEqualTo(0x02);
            ((uint)0x01).ShouldBeLessThanOrEqualTo(0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UInt_ShouldBeLessThanOrEqualToFailTest()
        {
            ((uint)0x44).ShouldBeLessThanOrEqualTo(0x43);
        }

        [TestMethod]
        public void UInt_ShouldBeBetweenPassTest()
        {
            ((uint)0x01).ShouldBeBetween(0x00, 0x05);
            ((uint)0x01).ShouldBeBetween(0x01, 0x05);
            ((uint)0x01).ShouldBeBetween(0x01, 0x05);
            ((uint)0x05).ShouldBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UInt_ShouldBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((uint)0x05).ShouldBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UInt_ShouldBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((uint)0x05).ShouldBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UInt_ShouldBeBetweenFailWhereLessThanLowerTest()
        {
            ((uint)0x01).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UInt_ShouldBeBetweenFailWhereGreaterThanUpperTest()
        {
            ((uint)0x06).ShouldBeBetween(0x02, 0x05);
        }

        [TestMethod]
        public void UInt_ShouldNotBeBetweenPassTest()
        {
            ((uint)0x06).ShouldNotBeBetween(0x00, 0x05);
            ((uint)0x00).ShouldNotBeBetween(0x01, 0x05);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UInt_ShouldNotBeBetweenFailWhereLowerGreaterThanUpperTest()
        {
            ((uint)0x05).ShouldNotBeBetween(0x02, 0x01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UInt_ShouldNotBeBetweenFailWhereLowerEqualToUpperTest()
        {
            ((uint)0x05).ShouldNotBeBetween(0x02, 0x02);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void UInt_ShouldNotBeBetweenFailTest()
        {
            ((uint)0x04).ShouldNotBeBetween(0x02, 0x05);
        }
    }
}
