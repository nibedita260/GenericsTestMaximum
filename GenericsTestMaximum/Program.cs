using System;

namespace GenericsTestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMaximum findMaximum = new FindMaximum();
            int x=findMaximum.FindMax(4,11,5);
            Console.WriteLine(x);
        }
    }
}
