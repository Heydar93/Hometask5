using TaskManagement.Common;
using TaskManagement.Database;

namespace TaskManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Available commands:");
                Console.WriteLine("/register");
                Console.WriteLine("/login");
                Console.WriteLine("/exit");

                Console.Write("Enter command:");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/register":
                        RegisterCommand.Handle();
                        break;
                    case "/login":
                        LoginCommand.Handle();
                        break;
                    case "/exit":
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
