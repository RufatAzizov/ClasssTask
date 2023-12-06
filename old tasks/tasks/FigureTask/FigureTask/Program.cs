namespace FigureTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("0. Quit\n");
            Figure square = new Square();
            Figure rect = new Rectangle();
            

            double UserNumber = Convert.ToDouble(Console.ReadLine());
            do
            {
                switch (UserNumber)
                {
                    case 0:
                        Console.WriteLine("bb");
                        break;

                    case 1:
                        Console.WriteLine("Enter side of the square: ");
                        double side1 = Convert.ToDouble(Console.ReadLine());
                        square.CalcArea();
                        break;

                    case 2:
                        Console.WriteLine("Enter 1 side of the rectangle ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter second side of the rectangle ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        rect.CalcArea();
                        break;
                    default: Console.WriteLine("Choose from given options");
                    break;
                }

            } while (UserNumber != 0);


        }
    }
}