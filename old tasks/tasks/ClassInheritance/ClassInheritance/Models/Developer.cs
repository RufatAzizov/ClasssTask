using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance.Models
{
    internal class Developer : Employee
    {
        public string[] KnownLanguages;

        public void WriteCode()
        {
            Console.Write($"{Name} {Surname} coding on ");
            for (int i = 0; i < KnownLanguages.Length; i++)
            {
                Console.Write(KnownLanguages[i]+ ", ");
            }
        }
    }
}
