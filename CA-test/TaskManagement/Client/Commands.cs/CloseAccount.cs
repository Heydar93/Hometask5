using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Client.Commands.cs
{
    public class CloseAccount
    {
        public static void Handle()
        {
            Console.WriteLine("Please enter an email :");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter password :");
            string password = Console.ReadLine();

            foreach (User user in DataContext.Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    Console.WriteLine("Your account deleted");
                    DataContext.Users.Remove(user);
                    return;
                }
            }
            Console.WriteLine("Email or Password are incorrect");
        }

    }
}
