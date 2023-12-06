using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] nums = { -66, -44, 3, -9, 100, -53, -88, 55 };
            //int max = nums[0];
            int negativeNumberCount = 0;
            int sum = 0;
            int minValue = nums[0], maxValue = nums[0];
            int maxIndex = 0;
            int secondMaxValue = nums[0];
            Console.WriteLine("Task 1:\n");
            for (int i = 0; i < nums.Length; i++)
            {
                //task 1

                Console.WriteLine((i + 1) + "th element: " + nums[i]);
                //task 2
                if (nums[i] < 0)
                {
                    negativeNumberCount++;
                }
                //task 3
                sum += nums[i];
                //task 4
                if (maxValue < nums[i])
                {
                    maxValue = nums[i];
                }
                if (minValue > nums[i])
                {
                    minValue = nums[i];
                }
                //task 5
                
            }
            Console.WriteLine("\nTask 2:\n");
            Console.WriteLine("Negative numbers count: " + negativeNumberCount);
            Console.WriteLine("\nTask 3:\n");
            Console.WriteLine("Arithmetic mean: " + sum / nums.Length);
            Console.WriteLine("\nTask 4:\n");
            Console.WriteLine("Sum of max and min number of arrays: " + (minValue + maxValue));*/
            //Console.WriteLine("\nTask 5:\n");
            //Console.WriteLine("Second max number: "+secondMaxValue);
            //task 6
            string response = "";
            do
            {
                Console.WriteLine("Enter your number between 10 and 20: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >= 10 && number <= 20)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Number is even");
                    } else
                    {
                        Console.WriteLine("Number is odd");
                    }
                } else
                {
                    Console.WriteLine("Number is in wrong range");
                }
                Console.WriteLine("Do you want to continue?(Y/Yes): ");
                response = Console.ReadLine();
            } while (response == "Y" || response == "Yes");
        }
    }
}