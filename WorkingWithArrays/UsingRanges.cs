using System;

#pragma warning disable CA1062

namespace WorkingWithArrays
{
    public static class UsingRanges
    {
        public static int[] GetArrayWithAllElements(int[] array)
        {

            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);

            return newArray;
        }

        public static int[] GetArrayWithoutFirstElement(int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            Array.Copy(array, 1, newArray, 0, array.Length - 1);
            return newArray;
        }

        public static int[] GetArrayWithoutTwoFirstElements(int[] array)
        {
            int[] newArray = new int[array.Length - 2];
            Array.Copy(array, 2, newArray, 0, array.Length - 2);
            return newArray;
        }

        public static int[] GetArrayWithoutThreeFirstElements(int[] array)
        {
            int[] newArray = new int[array.Length - 3];
            Array.Copy(array, 3, newArray, 0, array.Length - 3);
            return newArray;
        }

        public static int[] GetArrayWithoutLastElement(int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            Array.Copy(array, 0, newArray, 0, array.Length - 1);
            return newArray;
        }

        public static int[] GetArrayWithoutTwoLastElements(int[] array)
        {
            int[] newArray = new int[array.Length - 2];
            Array.Copy(array, 0, newArray, 0, array.Length - 2);
            return newArray;
        }

        public static int[] GetArrayWithoutThreeLastElements(int[] array)
        {
            int[] newArray = new int[array.Length - 3];
            Array.Copy(array, 0, newArray, 0, array.Length - 3);
            return newArray;
        }

        public static bool[] GetArrayWithoutFirstAndLastElements(bool[] array)
        {
            bool[] newArray = new bool[array.Length - 2];
            Array.Copy(array, 1, newArray, 0, array.Length - 2);
            return newArray;
        }

        public static bool[] GetArrayWithoutTwoFirstAndTwoLastElements(bool[] array)
        {
            bool[] newArray = new bool[array.Length - 4];
            Array.Copy(array, 2, newArray, 0, array.Length - 4);
            return newArray;
        }

        public static bool[] GetArrayWithoutThreeFirstAndThreeLastElements(bool[] array)
        {
            bool[] newArray = new bool[array.Length - 6];
            Array.Copy(array, 3, newArray, 0, array.Length - 6);
            return newArray;
        }
    }
}
