using System;

namespace GenericsTestMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            FindMaximum findMaximum = new FindMaximum();
            int x=findMaximum.FindMax(4,11,5);
            Console.WriteLine(x);
            float y=findMaximum.FindMax(2.5F, 2.2F, 2.8F);
            Console.WriteLine(y);
            string z=findMaximum.FindMax("Apple","Peach","Banana");
            Console.WriteLine(z);
=======
            Console.WriteLine("Maximum among three:");
            int [] intArray = {4,11,7};
            float [] floatArray = { 2.5f,2.2f,2.8f};
            string [] stringArray = {"Apple","Peach","Banana"};
            FindMaximum<int> findMaximum1 = new FindMaximum<int>(intArray);
            FindMaximum<float> findMaximum2 = new FindMaximum<float>(floatArray);
            FindMaximum<string> findMaximum3 = new FindMaximum<string>(stringArray);
            findMaximum1.PrintMax();
            findMaximum2.PrintMax();
            findMaximum3.PrintMax();
>>>>>>> UC5-PrintMaxUsingGenerics
        }
    }
}
