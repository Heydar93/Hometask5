namespace TaskManagement.Database.Models
{
    public class User
    {
        

        public static int IdCounter { get; private set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public  bool IsAdmin { get; set; }
        public  bool IsBanned { get; set; }
        public Message AssignedTo { get; set; }
        public DateTime RegistrationDate { get; set; }


        public User(string name, string lastName, string password, string email, bool isAdmin = false, bool isBanned = false)
        {
            Id = ++IdCounter;
            Name = name;
            LastName = lastName;
            Password = password;
            Email = email;
            IsAdmin = isAdmin;
            IsBanned = isBanned;
            AssignedTo = AssignedTo;
            RegistrationDate = DateTime.Now;

        }



        public string GetShortInfo()
        {
            return $"Id: {Id}, Full name: {Name} {LastName}, Email: {Email}, Is admin: {GetIsAdminInfo()}, Registration date: {RegistrationDate.ToString("dd/MM/yyyy")}";
        }

        public string GetIsAdminInfo()
        {
            return IsAdmin ? "Yes" : "No"; 
        }

        internal static void Add(string email, string? body, User user)
        {
            throw new NotImplementedException();
        }
    }
}