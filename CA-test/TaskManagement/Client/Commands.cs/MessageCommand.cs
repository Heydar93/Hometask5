using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Client.Commands.cs
{
    public class MessageCommand
    {
        public string From;
        public string To;
        public string Body;

        public void Handle()
        {
            Console.WriteLine("Please enter an email :");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter message :");
            string body = Console.ReadLine();

            foreach (User user in DataContext.Users)
            {
                if (email == user.Email)
                {
                    //User user = new User(email, body);
                    User.Add(email, body, user);
                    Console.WriteLine($"Message sent from {user} to {email}: {body}");
                }
            }
        }
    }
}
