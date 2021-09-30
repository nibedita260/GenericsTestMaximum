using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTestMaximum
{
    class FindMaximum<T> where T : IComparable
    {
        public T[] array;
        public FindMaximum(T[] arr)
        {
<<<<<<< HEAD
            Console.Write("The maximum among three numbers:");
            if(n1.CompareTo(n2)>0 && n1.CompareTo(n3)>0)
                return n1;
            if (n2.CompareTo(n1) > 0 && n2.CompareTo(n3) > 0)
                return n2;
            if (n3.CompareTo(n1) > 0 && n3.CompareTo(n2) > 0)
                return n3;
            return 0;
        }
        public float FindMax(float n1, float n2, float n3)
        {
            Console.Write("The maximum among three floats:");
            if (n1.CompareTo(n2) > 0 && n1.CompareTo(n3) > 0)
                return n1;
            if (n2.CompareTo(n1) > 0 && n2.CompareTo(n3) > 0)
                return n2;
            if (n3.CompareTo(n1) > 0 && n3.CompareTo(n2) > 0)
                return n3;
            return 0.0f;
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
=======
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
        public void PrintMax()
        {
            Console.WriteLine("Maximum Value is : " + this.FindMax());
>>>>>>> UC5-PrintMaxUsingGenerics
        }
    }
}
