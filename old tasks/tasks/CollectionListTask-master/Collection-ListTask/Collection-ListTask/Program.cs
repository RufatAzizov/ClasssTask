namespace Collection_ListTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection.IntList intList = new Collection.IntList(4,2,3,1);
            Console.WriteLine("\nPrint list");
            intList.Print();
            intList.Add(1);
            Console.WriteLine("\nPrint list");
            intList.Print();
            Console.WriteLine("\nThrough GetAll");
            int[] numbers = intList.GetAll();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("\nGet number on 3 index");
            Console.WriteLine(intList.Get(3000));
            Console.WriteLine("\nAdd numbers 77, 66 and 22");
            intList.Add(77, 66, 22);
            intList.Print();
            Console.WriteLine("\nAdd numbers 99, 120 and 770");
            intList.Add(99, 120, 770);
            intList.Print();
            Console.WriteLine("\nSort");
            //intList.Sort();
            intList.QuickSort();
            intList.Print();
            Console.WriteLine("\nSearch");
            Console.WriteLine(intList.BinarySearch(22));
        }
    }
}