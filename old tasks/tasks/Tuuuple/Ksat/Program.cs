using System.Security.Cryptography.X509Certificates;

namespace Ksat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Rufat", "Azizov", 20);
            
            Console.WriteLine($"{student.Name} {student.Surname} is {student.Age} years old\n ");
            var person = Tuple.Create("Ulvi", "U1viii", 26);
            Console.WriteLine($"Name: {person.Item1}\n" +
                $"Username: {person.Item2}\n" +
                $"Age: {person.Item3}\n");

            (string name, string username, byte age) person2 = ("Miki", "WereWolf", 20);

            Console.WriteLine($"Name: {person2.Item1}\n" +
                $"Username: {person2.Item2}\n" +
                $"Age: {person2.Item3}\n");

            Console.WriteLine(Tuple.Create($""));


        }



        
        public Student GetStudent()
        {
            Tuple.Create($"Fuad Helilov ");
            return null;
        }

        public record Student(string Name, string Surname, byte Age);

        
    }
}