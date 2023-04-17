using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.Commands;
using TaskManagement.Database;

namespace TaskManagement.Admin
{
    public class AdminDashboard
    {
        public static void Introduction()
        {
            Console.WriteLine("Hello dear admin");

            Console.WriteLine("Aviable commands:");
            Console.WriteLine("/depromote-from-admin");
            Console.WriteLine("/promote-to-admin");
            Console.WriteLine("//message-to");
            Console.WriteLine("/remove-user");
            Console.WriteLine("/show-users");
            Console.WriteLine("/show-user-by-email");
            Console.WriteLine("/show-user-by-id");
            Console.WriteLine("/add-user");
            Console.WriteLine("/logout");

            while (true)
            {
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/depromote-from-admin":
                        DePromoteFromAdmin.Handle();
                        break;
                    case "/message-to":
                        MessageTo.Handle();
                        break;
                    case "/remove-user":
                        RemoveUser.Handle();
                        break;
                    case "/update-settings":
                       UpdateSettings.Handle();
                        break;
                    case "/promote-to-admin":
                        PromoteToAdmin.Handle();
                        break;
                    case "/show-users":
                        ShowUsersCommand.Handle();
                        break;
                    case "/show-user-by-email":
                        ShowUserByEmailCommand.Handle();
                        break;
                    case "/show-user-by-id":
                        ShowUserByIdCommand.Handle();
                        break;
                    case "/add-user":
                        AddUserCommand.Handle();
                        break;
                    case "/logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }

    }
}
