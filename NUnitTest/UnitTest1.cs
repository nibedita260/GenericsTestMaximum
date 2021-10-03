using NUnit.Framework;
using System.Collections.Generic;
using GenericsTestMaximum;

namespace NUnitTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int max = 11;
            FindMaximum findMaximum = new FindMaximum();
            int res = findMaximum.FindMax(4, 11, 5);
            Assert.AreEqual(res, max);
        }
    }
}