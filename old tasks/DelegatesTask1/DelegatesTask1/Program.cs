namespace DelegatesTask1
{


    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> people = new List<People>();
            people.Add(new People("Rufat", "Azizov", 20));
            people.Add(new People("Fuad", "Adilov", 65));
            people.Add(new People("Mikayil", "Helilov", 30));

            foreach (People person in people)
            {
               people.FindAll(people => people.age >= 18);
            }

            people.FindAll(people => people.name.Length == 4);
                people.FindAll(people => people.surname.EndsWith("ov") || people.surname.EndsWith("ova"));
            

        }
    }
}