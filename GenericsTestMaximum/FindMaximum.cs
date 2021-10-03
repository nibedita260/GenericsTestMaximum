using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTestMaximum
{
<<<<<<< HEAD
    class FindMaximum<T> where T : IComparable
=======
    public class FindMaximum
>>>>>>> UC3-MaximumStrings
    {
        public T[] array;
        public FindMaximum(T[] arr)
        {
            this.array = arr;
        }
        public T[] Sort()
        {
            Array.Sort(array);
            return array;
        }
        public T FindMax()
        {
            T[] sorted = this.Sort();
            return sorted[sorted.Length - 1];
        }
        public string FindMax(string n1, string n2, string n3)
        {
            Console.Write("The maximum among three string:");
            if (n1.CompareTo(n2) > 0 && n1.CompareTo(n3) > 0)
                return n1;
            if (n2.CompareTo(n1) > 0 && n2.CompareTo(n3) > 0)
                return n2;
            if (n3.CompareTo(n1) > 0 && n3.CompareTo(n2) > 0)
                return n3;
            return null;
        }
    }
}
