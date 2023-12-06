using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeseyTaskNerminden
{
    public class Book : Product 
    {
        public string AuthorName { get; set; }
        public ushort PageCount { get; set; }

        public Book(string title, double price, uint count, string authorName, ushort pageCount ) 
        : base (title, price, count)
        {
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override void Sell()
        {

        }

        public override void ShowInfo()
        {

        }
    }
}
