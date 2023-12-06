namespace ClassTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car M5 = new Car("BMW", "M5");
            //Car M4 = new Car("BMW", "M4");
            //Car Supra = new Car("Toyota", "Supra");
            //Car CS = new Car("KIA", "CS");
            //Car[] cars = { M5, M4, Supra };
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i].GetCarInfo());
            //}
            //Console.WriteLine("----------------------------------");
            //Student Mikayil = new Student("Mikayil", "Adilov");
            //Console.WriteLine(Mikayil.GetStudentInfo());
            //Student Rufat = new Student("Rufat", "Azizov", "840i", 20);
            //Console.WriteLine(Rufat.GetStudentInfo());

            int[] nums = { 1, 3, 4, 5, 6 };
            bool addElement = false;
            do
            {
                Console.WriteLine("Do you want to add element?(Yes/yes/y): ");
                string response = Console.ReadLine();
                if (response == "Yes" || response == "yes" || response == "y" )
                {
                    addElement = true;
                    Array.Resize(ref nums, nums.Length+1);
                    Console.WriteLine("Enter new element: ");
                    nums[nums.Length-1] = Convert.ToInt32(Console.ReadLine());
                } else
                {
                    addElement = false;
                }
            } while (addElement);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}