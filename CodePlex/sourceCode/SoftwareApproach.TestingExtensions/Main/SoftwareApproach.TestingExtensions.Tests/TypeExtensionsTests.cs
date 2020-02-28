using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwareApproach.TestingExtensions.Tests
{
    [TestClass]
    public class TypeExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void Type_ShouldBeAssignableFromPassTest()
        {
            (typeof(ICollection)).ShouldBeAssignableFrom(typeof(IEnumerable));
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Type_ShouldBeAssignableFromFailTest()
        {
            (typeof(IEnumerable)).ShouldBeAssignableFrom(typeof(ICollection));
        }

        [TestMethod]
        public void Type_TypeParam_ShouldBeAssignableFromPassTest()
        {
            (typeof(IList)).ShouldBeAssignableFrom<IEnumerable>();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Type_TypeParam_ShouldBeAssignableFromFailTest()
        {
            (typeof(IEnumerable)).ShouldBeAssignableFrom<IList>();
        }
    }
}
