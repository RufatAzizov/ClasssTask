using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuuuple
{
    internal class Student
    {
        public string Name {  get; set; }
        public string Surname { get; set; }
        public byte Age {  get; set; }
        public record Group
        {
            public int StudentCount { get; set; }
            public string Faculty { get; set; }
        }
        public Result[] Results { get; set; }

        

    }
}
