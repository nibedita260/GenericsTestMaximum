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
            float max = 2.8f;
            FindMaximum findMaximum = new FindMaximum();
            float res = findMaximum.FindMax(2.5F, 2.2F, 2.8F);
            Assert.AreEqual(res, max);
        }
    }
}