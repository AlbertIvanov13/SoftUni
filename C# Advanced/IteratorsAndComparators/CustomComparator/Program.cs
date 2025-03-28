﻿using System.Collections.Generic;
using System;

namespace CustomComparator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(array, new CustomComparator());

            Console.WriteLine(string.Join(" ", array));
        }

        public class CustomComparator : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }
                
                if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }

                return x.CompareTo(y);
            }
        }
    }
}