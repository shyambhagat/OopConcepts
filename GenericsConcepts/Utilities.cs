using System;
using System.Collections.Generic;

namespace GenericsConcepts
{
    public static class Utilities
    {
        // Generic method to find the maximum of two values
        public static T Max<T>(T value1, T value2) where T : IComparable<T>
        {
            return value1.CompareTo(value2) > 0 ? value1 : value2;
        }

        // Generic method to swap two values
        public static void Swap<T>(ref T value1, ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
}