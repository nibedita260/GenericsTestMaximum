using System;

namespace GenericsTestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum among three:");
            int [] intArray = {4,11,7};
            float [] floatArray = { 2.5f,2.2f,2.8f};
            string [] stringArray = {"Apple","Peach","Banana"};
            FindMaximum<int> findMaximum1 = new FindMaximum<int>(intArray);
            FindMaximum<float> findMaximum2 = new FindMaximum<float>(floatArray);
            FindMaximum<string> findMaximum3 = new FindMaximum<string>(stringArray);
            Console.WriteLine("Maximum Integer Number : " + findMaximum1.FindMax());
            Console.WriteLine("Maximum Float Number : " + findMaximum2.FindMax());
            Console.WriteLine("Maximum String : " + findMaximum3.FindMax());
        }
    }
}
