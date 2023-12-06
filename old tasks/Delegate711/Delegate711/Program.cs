using System;

namespace Delegate711
{

    public delegate int myDelegate(int a, int b); 
    internal class Program
    {
        static void Main(string[] args)
        {

            myDelegate del = Multiply;
            myDelegate del2 = Sum;
            myDelegate del3 = Subtract;

            Console.WriteLine(del(1, 2));
            Console.WriteLine(del2(1, 5));
            Console.WriteLine(del3(2, 5));

            static int Multiply(int a, int b)
            {
                return a*b;
            }

            static int Sum(int a, int b)
            {
                return a+b;
            }

            static int Subtract(int a, int b)
            {
                return a-b;
            }



        }
    }
}