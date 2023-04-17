using System.Runtime.CompilerServices;
using TaskManagement.Admin;
using TaskManagement.Admin.Commands;
using TaskManagement.Client;
using TaskManagement.Database;
using TaskManagement.Database.Models;

namespace TaskManagement.Common
{
    public class LoginCommand
    {
        public static void Handle() //use alias
        {
            string email = Console.ReadLine()!;
            string password = Console.ReadLine()!;

            for (int i = 0; i < DataContext.Users.Count; i++)
            {
                User user = DataContext.Users[i];

                if (user.Email == email && user.Password == password)
                {
                    if (user.IsAdmin)
                    {
                        AdminDashboard.Introduction();
                    }
                    else if (user.IsBanned)
                    {
                        Console.WriteLine($"{user.Name} already banned");
                    }
                    else
                    {
                        ClientDashboard.Introduction(user);
                    }

                }
            }
        }
    }
}
