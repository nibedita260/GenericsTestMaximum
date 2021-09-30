using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTestMaximum
{
    class FindMaximum
    {
        public int FindMax(int n1,int n2,int n3)
        {
            int max = 0;
            Console.Write("The maximum among three numbers:");
            if(n1.CompareTo(n2)>0 && n1.CompareTo(n3)>0)
            {
                max = n1;
            }
            if (n2.CompareTo(n1) > 0 && n2.CompareTo(n3) > 0)
            {
                max = n2;
            }
            if (n3.CompareTo(n1) > 0 && n3.CompareTo(n2) > 0)
            {
                max = n3;
            }
            Console.Write(max);
            Console.WriteLine(" ");
            return max;
        }
        public float FindMaxFloats(float n1, float n2, float n3)
        {
            float max = 0;
            Console.Write("The maximum among three numbers:");
            if (n1.CompareTo(n2) > 0 && n1.CompareTo(n3) > 0)
            {
                max = n1;
            }
            if (n2.CompareTo(n1) > 0 && n2.CompareTo(n3) > 0)
            {
                max = n2;
            }
            if (n3.CompareTo(n1) > 0 && n3.CompareTo(n2) > 0)
            {
                max = n3;
            }
            Console.Write(max);
            Console.WriteLine(" ");
            return max;
        }
    }
}
