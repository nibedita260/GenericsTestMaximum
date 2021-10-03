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
<<<<<<< HEAD
            float y=findMaximum.FindMax(2.5F, 2.2F, 2.8F);
            Console.WriteLine(y);
=======
>>>>>>> UC1-MaxNumber
        }
    }
}
