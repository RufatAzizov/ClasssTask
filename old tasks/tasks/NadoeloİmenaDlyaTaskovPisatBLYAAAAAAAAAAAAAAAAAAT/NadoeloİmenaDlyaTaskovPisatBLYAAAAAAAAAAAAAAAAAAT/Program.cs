using System;

namespace NadoeloİmenaDlyaTaskovPisatBLYAAAAAAAAAAAAAAAAAAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 1, 4, 8, 11, 9, 0 };
            //ArraySwapMaxAndMin(a);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            //int a = 5;
            //int b = 8;
            //Console.WriteLine("a: "+a+" b: "+b);
            //SwapVariables(ref a, ref b);
            //Console.WriteLine("a: " + a + " b: " + b);

        }
        static int ArrayMinIndex(params int[] array)
        {
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }
        static int ArrayMaxIndex(params int[] array)
        {
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        static void ArraySwapMaxAndMin(params int[] array)
        {
            int maxIndex = ArrayMaxIndex(array);
            int minIndex = ArrayMinIndex(array);
            array[maxIndex] = array[maxIndex] + array[minIndex];
            array[minIndex] = array[maxIndex] - array[minIndex];
            array[maxIndex] = array[maxIndex] - array[minIndex];
            
        }

        static void SwapVariables(ref int variableOne, ref int variableTwo)
        {
            variableOne = variableTwo + variableOne;
            variableTwo = variableOne - variableTwo;
            variableOne = variableOne - variableTwo;
        }


    }
}