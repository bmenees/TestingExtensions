using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class ICollectionExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void ICollection_ShouldBeEmptyPassTest()
        {
            List<int> source = new List<int>();
            source.ShouldBeEmpty();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ICollection_ShouldBeEmptyFailTest()
        {
            List<int> source = new List<int>() { 1 };
            source.ShouldBeEmpty();
        }

        [TestMethod]
        public void ICollection_ShouldNotBeEmptyPassTest()
        {
            List<int> source = new List<int>() { 1 };
            source.ShouldNotBeEmpty();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ICollection_ShouldNotBeEmptyFailTest()
        {
            List<int> source = new List<int>();
            source.ShouldNotBeEmpty();
        }

        [TestMethod]
        public void ICollection_ShouldContainPassTest()
        {
            List<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldContain(2);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ICollection_ShouldContainFailTest()
        {
            List<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldContain(6);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ICollection_ShouldContainWhereEmptyCollectionFailTest()
        {
            List<int> source = new List<int>();
            source.ShouldContain(6);
        }

        [TestMethod]
        public void ICollection_ShouldNotContainPassTest()
        {
            List<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldNotContain(6);

            source = new List<int>();
            source.ShouldNotContain(1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ICollection_ShouldNotContainFailTest()
        {
            List<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldNotContain(2);
        }

        [TestMethod]
        public void ICollection_ShouldHaveCountOfPassTest()
        {
            List<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldHaveCountOf(5);

            source = new List<int>();
            source.ShouldHaveCountOf(0);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ICollection_ShouldHaveCountOfFailTest()
        {
            List<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldHaveCountOf(3);
        }
    }
}
