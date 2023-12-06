using System.Runtime.CompilerServices;

namespace GeseyTaskNerminden
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte input;

       
            do
            {
                Console.WriteLine("1 - Add book");
                Console.WriteLine("2 - Sell book ");
                Console.WriteLine("3 - Show info about book");
                Console.WriteLine("4 - Get book ID\n");
                input = Convert.ToByte(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Library.AddBook(new Book("LOTR", 39, 4, "JJR Tolkien", 475)); 
                            break;
                       
                    case 2:

                    case 3:

                    case 4:

                    break;

                    default:

                    break; 

                }

               
            } while (input < 5);
            



        }
    }
}