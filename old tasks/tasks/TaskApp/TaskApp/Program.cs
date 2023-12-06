using System.Runtime.InteropServices;

namespace TaskApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            int[] nums = {0, 0, 1, 1, 49, 49, 5787, 6666, 77, 77,1 };
            int count = 0;
            string tempResponse = "";
            string[] response = { };
            for (int i = 0; i < nums.Length; i++)
            {
                count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j]) { 
                        count++; 
                    } 
                }
                response[i] = nums[i]+" -> "+count;
                for (int j = 0;j < response.Length; j++)
                {
                    if (response[i] == response[j])
                    {
                        continue;
                    } else
                    {
                        Console.WriteLine(response[i]);
                    }
                }
            }
            //task 2
            //Console.WriteLine("Enter size of array: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Do you want to enter your array elemesnts?(Yes/No): ");
            //string answer = Console.ReadLine();
            //bool continueApp = answer == "Yes" ? true : false;
        }
    }
}