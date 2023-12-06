using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0211.Utilities.Exceptions
{
    public class InvalidPhoneFormat : Exception
    {
        public InvalidPhoneFormat(string message) : base(message)
        {

        }
    }
}
