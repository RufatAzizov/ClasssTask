using ConsoleApp0211.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp0211.Models
{
    public class User
    {

        public string name { get; set; }
        public byte age { get; set; }
        public string phoneNumber { get; set; }
        private string password;

        public User(string name, byte age, string phoneNumber, string password)
        {
            try
            {
                SetName(name);
               

            }
            catch (InvalidNameException a)
            {
                Console.WriteLine(a.Message);
            }

            // чтобы все эксы выходили на консоль
            try
            {
                SetAge(age);
                SetPhoneNumber(phoneNumber);
                SetPassword(password);
            }
            catch (InvalidAgeException a)
            {
                Console.WriteLine(a.Message);
            }
            catch (InvalidPhoneFormat a)
            {
                Console.WriteLine(a.Message);
            }
            catch (InvalidPasswordException a)
            {
                Console.WriteLine(a.Message);
            }
        }

        

        public void SetName(string name)
        {
            if (name.Length < 2 || name.Length > 30)
            {
                throw new InvalidNameException("Name must be between 2 and 30 characters.");
            }
            this.name = name;
        }

        public void SetAge(byte age)
        {
            if (age <= 0)
            {
                throw new InvalidAgeException("Write a correct age");
            }
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            Regex phoneFormat1 = new Regex(@"^\+994(50|55|70|99)\d{3}\d{2}\d{2}$");
            Regex phoneFormat2 = new Regex(@"^(050|055|070|099)\d{3}\d{2}\d{2}$");

            if (phoneFormat1.IsMatch(phoneNumber) || phoneFormat2.IsMatch(phoneNumber))
            {
                phoneNumber = phoneNumber;
            }
            else { throw new InvalidPhoneFormat("Invalid phone number format."); }
        }

        public void SetPassword(string password)
        {
            if (password.Length < 8 || !Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)"))
            {
                throw new InvalidPasswordException("Invalid password format.");
            }
            this.password = password;
        }



    }
}
