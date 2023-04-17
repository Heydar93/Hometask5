using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Admin.Commands
{
    public class DePromoteFromAdmin
    {
        public static void Handle()
        {
            Console.WriteLine("Please enter an email :");
            string email = Console.ReadLine()!;

            foreach (User user in DataContext.Users)
            {
                if (user.Email == email)
                {
                    if (user.IsAdmin)
                    {
                        user.IsAdmin = false;
                        Console.WriteLine($"{user.Name} is now user");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{user.Name} is already user");
                        return;
                    }
                }
            }
            Console.WriteLine("Email not found");





        }
    }
}
