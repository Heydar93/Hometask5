using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Utilities;

namespace TaskManagement.Common
{
    public class UserValidator
    {
        private StringUtility _utility = new StringUtility();


        #region First name

        public string GetAndValidateFirstName()
        {
            while (true)
            {
                Console.WriteLine("Pls enter first name : ");
                string firstName = Console.ReadLine()!;

                if (IsValidFirstName(firstName))
                    return firstName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        private bool IsValidFirstName(string firstName)
        {
            int MIN_LENGTH = 3;
            int MAX_LENGTH = 30;

            return IsValidName(firstName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Last name

        public string GetAndValidateLastName()
        {
            while (true)
            {
                Console.WriteLine("Pls enter last name : ");
                string lastName = Console.ReadLine()!;

                if (IsValidLastName(lastName))
                    return lastName;

                Console.WriteLine("Some information is not correnct");
            }
        }
        private bool IsValidLastName(string lastName)
        {
            int MIN_LENGTH = 5;
            int MAX_LENGTH = 20;

            return IsValidName(lastName, MIN_LENGTH, MAX_LENGTH);
        }

        #endregion

        #region Password

        public string GetAndValidatePassword()
        {
            while (true)
            {
                Console.WriteLine("Pls enter password : ");
                string password = Console.ReadLine()!;

                Console.WriteLine("Pls enter confirm password : ");
                string confirmPassword = Console.ReadLine()!;

                if (password == confirmPassword)
                    return password;

                Console.WriteLine("Some information is not correnct");
            }
        }

        #endregion

        #region Email

        public string GetAndValidateEmail()
        {
            while (true)
            {
                Console.WriteLine("Please enter your email:");
                string email = Console.ReadLine();

                if (IsValidEmail(email))
                {
                    // check if email is already in use in the system
                    bool isEmailInUse = CheckIfEmailIsInUse(email);
                    if (isEmailInUse)
                    {
                        Console.WriteLine("This email is already in use. Please try another email.");
                    }
                    else
                    {
                        return email;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid email format. Please enter a valid email.");
                }
            }
        }

        static bool IsValidEmail(string email)
        {
            bool isValid = Regex.IsMatch(email, @"^[a-zA-Z0-9]{10,30}@code\.edu\.az$");
            if (isValid)
            {
                return true;
            }
            return false;
        }

        static bool CheckIfEmailIsInUse(string email)
        {
            return false;
        }
        #endregion


        #region Common

        private bool IsValidName(string name, int minLength, int maxLenght)
        {
            if (!_utility.IsLengthBetween(name, minLength, maxLenght))
            {
                return false;
            }

            char firstLetter = name[0];

            if (!_utility.IsUpperLetter(firstLetter))
            {
                return false;
            }

            for (int i = 1; i < name.Length; i++)
            {
                if (_utility.IsUpperLetter(name[i]))
                {
                    return false;
                }
            }
            return true;

        }
    }

    
}





#endregion

