using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTasks
{
    public class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Age;
        public bool HasScholarship;

        public string GetStudentInfo ()
        {
            return $"Student Name: {Name}, Surname: {Surname}, Group: {Group}, Age: {Age}, Sholarship Status: {HasScholarship}";
        }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Student(string name, string surname, string group, int age) : this(name, surname)
        {
            Group = group;
            Age = age;
        }
    }
}
