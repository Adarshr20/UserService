using UserService.Repository;
using UserService;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        run();
    }

    static void run()
    {
        UserService.UserService userService = new UserService.UserService();

        // Add users
        userService.AddUser(new User { Id = 1, Name = "Adarsh", Email = "adarsh@gmail.com", Contact = "1234567890" });
        userService.AddUser(new User { Id = 2, Name = "Aditya", Email = "aditya@gmail.com", Contact = "9876543210" });

        // Update user property
        userService.UpdateUser(new User { Id = 2, Name = "Gopu", Email = "gopu@gmail.com", Contact = "123456789" });

        // Remove user
        userService.RemoveUser(2);
    }
}