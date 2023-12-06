using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           doner ingridients = new doner();
            ingridients.n1 = "Meat";
            ingridients.n2 = "Banana";
            ingridients.n3 = "Sauce";
        }

        public class doner
        {
            public string n1;
            public string n2;
            public string n3;

            
        }


    }
}