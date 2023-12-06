using System.Diagnostics;

namespace MethodTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array1 = { 1, 2, 3 };
            //int[] combinedArray = CombineArrays(array1, 4 , 3 , 5);
            //for (int i = 0; i < combinedArray.Length; i++) 
            //{
            //    Console.WriteLine(combinedArray[i]);
            //}
            //Console.WriteLine(NumberInPowerOf(3, 3));
            //Console.WriteLine(ArrayMin(1,2,3,5,6,0));
            //Console.WriteLine(ArrayMaxAndMinMultiplied(2,99,5,100));
            //Console.WriteLine(IsNumberEvenOrOdd(4));
            FindPrimeFactors(36);
            //Console.WriteLine(Sum(5,6));
            //Console.WriteLine(Difference(5, 6));
            //Console.WriteLine(Division(5, 6));
            //Console.WriteLine(Multiplacation(5, 6));

        }
        //task 1
        static int[] CombineArrays(int[] array1, params int[] array2)
        {
            int[] combinedArray = new int[array1.Length + array2.Length];
            for (int i = 0; i < combinedArray.Length; i++)
            {
                if (i < array1.Length)
                {
                    combinedArray[i] = array1[i];
                }
                else
                {
                    combinedArray[i] = array2[i - array1.Length];
                }
            }

            return combinedArray;
        }
        //task 2
        static int ArrayMin(params int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        //task 3 
        static int ArrayMaxAndMinMultiplied(params int[] array)
        {
            int min = array[0];
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return min * max;
        }
        //task 4
        static int NumberInPowerOf(int number, int power)
        {
            int temp = number;
            //int numberInPowerOf = number ^ power;
            for (int i = 1; i <= power - 1; i++)
            {
                number *= temp;
            }
            return number;
        }
        //task 5
        static string IsNumberEvenOrOdd(int number)
        {
            string result = "";
            if (number % 2 == 0)
            {
                result += "Digit is even";
            }
            else
            {
                result += "Digit is odd";
            }
            return result;
        }
        //task 6
        static void FindPrimeFactors(int number)
        {
            Console.Write(number + "->");
            for (int i = 2; number > 1; i++) { 
                if (number % i == 0)
                {
                    int count = 0;
                    while (number % i == 0)
                    {
                        number /= i;
                        count++;
                    }
                    Console.Write(i+" is a prime fractor "+count+" times, ");
                }
            }
        }
        //task 7
        static int Sum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
        static int Difference(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }
        static int Multiplacation(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }
        static int Division(int numberOne, int numberTwo)
        {
            return numberOne / numberTwo;
        }
        //task 8
        static void PrintFullName(string name)
        {
            Console.WriteLine("User name is "+name);
        }
        static void PrintFullName(string name, string username)
        {
            Console.WriteLine(username+ "name is " + name);
        }
        static void PrintFullName(string name, string username, string surname)
        {
            Console.WriteLine(username+" fullname is " + name + surname);
        }
    }
}