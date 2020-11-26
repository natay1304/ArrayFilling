using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstArrayIsNotFilled()
        {
            string[] a = new string[] { null, null, "q", "w", null, null };
            string[] b = new string[] { "1", "10" };

            var nullCount1 = a.Count(i => i == null);

            Task.Arrays.RandomArrayFilling(a, b);

            var nullCount2 = a.Count(i => i == null);

            Assert.AreEqual((nullCount1 - b.Length), nullCount2);
        }

        [TestMethod]
        public void FirstArrayIsFilled()
        {
            string[] a = new string[] { null, null, "q", "w", null, null };
            string[] b = new string[] { "1", "10", "5", "4", "90" };
            int nullCount1 = 0;
            int nullCount2 = 0;

            nullCount1 = a.Count(i => i == null);

            Task.Arrays.RandomArrayFilling(a, b);

            nullCount2 = a.Count(i => i == null);

            Assert.AreNotEqual((nullCount1 - b.Length), nullCount2);
            Assert.AreEqual(0, nullCount2);
        }
    }
}
