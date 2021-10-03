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
            string max = "Peach";
            FindMaximum findMaximum = new FindMaximum();
            string res = findMaximum.FindMax("Apple", "Peach", "Banana");
            Assert.AreEqual(res, max);
        }
    }
}