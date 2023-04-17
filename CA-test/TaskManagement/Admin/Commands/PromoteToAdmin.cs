using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class PromoteToAdmin
    {
        public static void Handle()
        {
            Console.WriteLine("Please enter an email :");
            string email = Console.ReadLine();


            foreach (User user in DataContext.Users)
            {
                if (user.Email == email)
                {
                    if (user.IsAdmin)
                    {
                        Console.WriteLine("Already admin!");
                        return;
                    }
                    else
                    {
                        user.IsAdmin = true;
                        Console.WriteLine($"{user.Name} is now admin");
                        return;

                    }
                }
            }
            Console.WriteLine("Email not found");




        }
    }
}
