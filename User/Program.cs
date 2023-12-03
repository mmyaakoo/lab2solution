using System;



class Program
{
    static void Main()
    {
        // Create an instance of the User class
        User user = new User("john_doe", "John", "Doe", 25);

        // Display user information
        user.DisplayUserInfo();

        // Keep the console window open
        Console.ReadLine();
    }
}
