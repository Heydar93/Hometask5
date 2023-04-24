using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.Commands;
using TaskManagement.Client.Commands.cs;
using TaskManagement.Database.Models;

namespace TaskManagement.Client
{
    public class ClientDashboard
    {
        public static void Introduction(User user)
        {
            Console.WriteLine($"Hello! : {user.Email} {user.Password}");
            UpdateSettingsForUser updateSettingsForUser = new UpdateSettingsForUser();

            while (true)
            {
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/update-user":
                        updateSettingsForUser.Handle();
                        return;
                    case "/close-account":
                        CloseAccount.Handle();
                        return;
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
