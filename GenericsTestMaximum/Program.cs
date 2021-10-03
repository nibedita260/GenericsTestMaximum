using System;

namespace GenericsTestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMaximum findMaximum = new FindMaximum();
            string z=findMaximum.FindMax("Apple","Peach","Banana");
            Console.WriteLine(z);
        }
    }
}
