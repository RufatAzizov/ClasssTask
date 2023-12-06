using System;

namespace palindromNumberTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            //int num, rev, sum = 0, temp;
            //Console.Write("Enter the number: ");
            //num = Convert.ToInt32(Console.ReadLine());
            //temp = num;
            //while (num > 0)
            //{
            //    rev = num % 10; //1,2
            //    sum = (sum * 10) + rev;//1
            //    num = num / 10; //12
            //}
            //if (temp == sum)
            //    Console.Write("The given number is Palindrome.");
            //else
            //    Console.Write("The given number is not Palindrome.");
            ////task 2
            //int[] swapArray = { 30, 50, 80, 100, 110 };
            //int maxElement = swapArray[0], minElement = swapArray[0]; ;
            //int maxIndex = 0, minIndex = 0;
            //for (int i = 0; i < swapArray.Length; i++)
            //{
            //    int entry = swapArray[i];

            //    if (maxElement > entry)
            //    {
            //        maxIndex = i;
            //    }
            //    if (minElement < entry)
            //    {
            //        minIndex = i;
            //    }

            //}
            //swapArray[maxIndex] = swapArray[maxIndex] + swapArray[minIndex];
            //swapArray[minIndex] = swapArray[maxIndex] - swapArray[minIndex];
            //swapArray[maxIndex] = swapArray[maxIndex] - swapArray[minIndex];
            //for (int n = 0; n < swapArray.Length; n++)
            //{
            //    Console.WriteLine(swapArray[n]);
            //}
            //task 3
            int number = 122;

            int[] digits = new int[10];
            int digitsTest = 0;

            int temp = number;
            while (temp != 0)
            {
                int digit = temp % 10;
                digits[digit]++;
                temp /= 10;
                if (digit == temp) {
                    digitsTest++;
                }
            }

            bool hasRepeatingDigits = false;

            if (digitsTest > 1)
            {
                hasRepeatingDigits = true;
            }

            //for (int i = 0; i < digits.Length; i++)
            //{
            //    if (digits[i] > 1)
            //    {
            //        hasRepeatingDigits = true;
            //        break;
            //    }
            //}

            if (hasRepeatingDigits)
            {
                Console.WriteLine("Number has repeating digits.");
            }
            else
            {
                Console.WriteLine("Number does not have repeating digits.");
            }
            //task 4
            //string name = "Mikayil";
            //string surname = "Adilov";
            //Console.WriteLine(surname[0]+". "+name);
            //task 5
            //int[] array = { -1, 1, -2 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < 0)
            //    {
            //        array[i] = array[i] * -1;
            //    }
            //}
            //for (int i = 0;i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
        }
    }
}