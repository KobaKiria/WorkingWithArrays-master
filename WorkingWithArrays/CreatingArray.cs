using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        public static int[] CreateEmptyArrayOfIntegers()
        {
            int[] emptyIntArray = new int[0];
            return emptyIntArray;
        }

        public static bool[] CreateEmptyArrayOfBooleans()
        {
            bool[] emptyBoolArray = new bool[0];
            return emptyBoolArray;
        }

        public static string[] CreateEmptyArrayOfStrings()
        {
            string[] emptyStringArray = new string[0];
            return emptyStringArray;
        }

        public static char[] CreateEmptyArrayOfCharacters()
        {
            char[] emptyCharArray = new char[0];
            return emptyCharArray;
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            double[] emptyDoubelerray = new double[0];
            return emptyDoubelerray;
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            float[] emptyfloatrray = new float[0];
            return emptyfloatrray;
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            decimal[] emptyDecimalrray = new decimal[0];
            return emptyDecimalrray;
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            int[] intArray = new int[10];
            return intArray;
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            bool[] boolArray = new bool[20];
            return  boolArray;
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            string[] stringArray = new string[5];
            return stringArray;
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            char[] charArray = new char[15];
            return charArray;
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            double[] doubleArray = new double[18];
            return doubleArray;
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            float[] floatArray = new float[100];
            return floatArray;
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            decimal[] decimalArray = new decimal[1000];
            return decimalArray;
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            int[] intArray = { 123_456 };
            return intArray;
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            int[] intArray = { 1_111_111, 9_999_999 };
            return intArray;
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            int[] intArray = { 0, 4_234, 3_845, 2_942, 1_104, 9_794, 0_923_943, 7_537, 4_162, 10134 };
            return intArray;
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            bool[] boolArray = { true };
            return boolArray;
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            bool[] boolArray = { true, false, true, false, true };
            return boolArray;
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            bool[] boolArray = { false, true, true, false, true, true, false };
            return boolArray;
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            string[] stringArray = { "one" };
            return stringArray;
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            string[] stringArray = { "one", "two", "three" };
            return stringArray;
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            string[] stringArray = { "one", "two", "three", "four", "five", "six" };
            return stringArray;
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            char[] charArray = { 'a' };
            return charArray;
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            char[] charArray = { 'a', 'b', 'c' };
            return charArray;
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
            return charArray;
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            double[] doubleArray = { 1.12 };
            return doubleArray;
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            double[] doubleArray = { 1.12, 2.23, 3.34, 4.45, 5.56 };
            return doubleArray;
        }

        public static double[] CreateDoubleWithNineElements()
        {
            double[] doubleArray = { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
            return doubleArray;
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            float[] floatArray = { 123_456_789.12_34_56f };
            return floatArray;
        }

        public static float[] CreateFloatWithThreeElements()
        {
            float[] floatArray = { 10_000_00.12_34_56f, 222_333_4444.12_34_56f, 9999.999999f };
            return floatArray;
        }

        public static float[] CreateFloatWithFiveElements()
        {
            float[] floatArray = { 1.01_23f, 20.01_23_45f, 300.01_23_45_67f, 4_000.0123_4567f, 50_0000.01234567f };
            return floatArray;
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            decimal[] decimalArray = { 10_000.12_34_56m };
            return decimalArray;
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            decimal[] decimalArray = { 1_000.12_34m, 10_0000.23_45m, 100_000.34_56m, 1_000_000.4567_89m, 10000000.5678901m };
            return decimalArray;
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            decimal[] decimalArray = { 10.12_21_12M, 200.23_32_23M, 3_000.34_43_34M, 40_000.45_54_45M, 500_000.56_65_56M, 6_000_000.67_76_67M, 70_000_000.78_87_78M, 800_000_000.89_98_89M, 9_000_000_000.91_19_91M };
            return decimalArray;
        }
    }
}
