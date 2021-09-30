using System;

namespace GenericsTestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMaximum findMaximum = new FindMaximum();
            findMaximum.FindMax(4,11,5);
            findMaximum.FindMaxFloats(2.5F, 2.2F, 2.8F);
        }
    }
}
