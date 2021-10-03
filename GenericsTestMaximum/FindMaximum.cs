﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsTestMaximum
{
    public class FindMaximum<T> where T : IComparable
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
        public void PrintMax()
        {
            Console.WriteLine("Maximum Value is : " + this.FindMax());
        }
    }
}
