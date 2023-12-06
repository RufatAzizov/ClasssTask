using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeseyTaskNerminden
{
    public class Library
    {
          static Book[] books = new Book[0];
        public static void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
            Console.WriteLine("Book added\n");
        }

        public void GetBookById(uint id) 
        {
            
        } 
    }
}
