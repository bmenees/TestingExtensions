using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class IEnumerableExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void IEnumerable_ShouldBeEmptyPassTest()
        {
            IEnumerable<int> source = new List<int>();
            source.ShouldBeEmpty();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void IEnumerable_ShouldBeEmptyFailTest()
        {
            IEnumerable<int> source = new List<int>() { 1 };
            source.ShouldBeEmpty();
        }

        [TestMethod]
        public void IEnumerable_ShouldNotBeEmptyPassTest()
        {
            IEnumerable<int> source = new List<int>() { 1 };
            source.ShouldNotBeEmpty();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void IEnumerable_ShouldNotBeEmptyFailTest()
        {
            IEnumerable<int> source = new List<int>();
            source.ShouldNotBeEmpty();
        }

        [TestMethod]
        public void IEnumerable_ShouldContainPassTest()
        {
            IEnumerable<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldContain(2);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void IEnumerable_ShouldContainFailTest()
        {
            IEnumerable<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldContain(6);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void IEnumerable_ShouldContainWhereEmptyCollectionFailTest()
        {
            IEnumerable<int> source = new List<int>();
            source.ShouldContain(6);
        }

        [TestMethod]
        public void IEnumerable_ShouldNotContainPassTest()
        {
            IEnumerable<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldNotContain(6);

            source = new List<int>();
            source.ShouldNotContain(1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void IEnumerable_ShouldNotContainFailTest()
        {
            IEnumerable<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldNotContain(2);
        }

        [TestMethod]
        public void IEnumerable_ShouldHaveCountOfPassTest()
        {
            IEnumerable<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldHaveCountOf(5);

            source = new List<int>();
            source.ShouldHaveCountOf(0);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void IEnumerable_ShouldHaveCountOfFailTest()
        {
            IEnumerable<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldHaveCountOf(3);
        }

        [TestMethod]
        public void IEnumerable_ShouldNotHaveCountOfPassTest()
        {
            IEnumerable<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldNotHaveCountOf(4);

            source = new List<int>();
            source.ShouldNotHaveCountOf(1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void IEnumerable_ShouldNotHaveCountOfFailTest()
        {
            IEnumerable<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldNotHaveCountOf(5);
        }

        [TestMethod]
        public void IEnumerable_ShouldHaveCountOfAtLeastPassTest()
        {
            IEnumerable<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldHaveCountOfAtLeast(4);

            source = new List<int>();
            source.ShouldHaveCountOfAtLeast(0);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void IEnumerable_ShouldHaveCountOfAtLeastFailTest()
        {
            IEnumerable<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldHaveCountOfAtLeast(6);
        }

        [TestMethod]
        public void IEnumerable_ShouldHaveCountOfAtMostPassTest()
        {
            IEnumerable<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldHaveCountOfAtMost(6);

            source = new List<int>();
            source.ShouldHaveCountOfAtMost(0);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void IEnumerable_ShouldHaveCountOfAtMostFailTest()
        {
            IEnumerable<int> source = new List<int>() { 1, 2, 3, 4, 5 };
            source.ShouldHaveCountOfAtMost(4);
        }
    }
}
