using Company_Project;

/*Employee e = new Employee("vugar","sariyev","vugar123");

Company company1 = new Company("Socar kbr");*/




/*while (true) // quit
{
    Console.WriteLine("1. Create a company");
    Console.WriteLine("2. Create an employee");
    Console.WriteLine("3. Add employee");
    char option = Convert.ToChar(Console.ReadLine());

    switch (option)
    {
        case '1':

            break;
        case '2':
            company1.AddUser(e);

            break;
        case '3':

            break;
    }
}*/
Company company1 = new Company("Socar kbr"); ;
//company1.Employees[0] = new Employee("Vuqar", "Filanov", "Xiyar123");
///Employee e = new Employee("vugar", "sariyev", "vugar123");
char option;
do 
{
    Console.WriteLine("1. Create a company");
    Console.WriteLine("2. Create an employee");
    Console.WriteLine("3. Add employee");
    Console.WriteLine("4. Get one employee");
    Console.WriteLine("5. To update employee data");
    Console.WriteLine("6. To see all users");
    Console.WriteLine("7. To remove user\n");
    option = Convert.ToChar(Console.ReadLine());

    switch (option)
    {
        case '1':
            company1 = new Company("Socar kbr");
            break;
        case '2':
            company1.Employees[0] = new Employee("vugar", "sariyev", "vugar123");
            break;
        case '3':
            Console.WriteLine("Name day suka");
            string name = Console.ReadLine();
            Console.WriteLine("Surname blyat");
            string surname = Console.ReadLine();
            Console.WriteLine("Username AAAAAAAA");
            string username = Console.ReadLine();
            company1.AddUser(new Employee(name, surname, username));
            break;
        case '4':
            company1.GetUser(company1.Employees[0].Username);
            break;
        case '5':
            company1.UpdateUser(company1.Employees[0].Username);
            break;
        case '6':
            company1.GetAllUser();
            break;
        case '7':
            Console.WriteLine("Username AAAAAAAA");
            string usernameUAGLUIDGUDGUD = Console.ReadLine();
            company1.RemoveUser(usernameUAGLUIDGUDGUD);
            break;
        default:
            Console.WriteLine("Choose from options");
            break;
    }
} while (option != 'q');
