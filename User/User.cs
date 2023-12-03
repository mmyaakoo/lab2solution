class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate; // Readonly field for the registration date

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now; // Initialize the registration date only once
    }

    public void DisplayUserInfo()
    {
        // Display user information
        Console.WriteLine("User Information:");
        Console.WriteLine($"Login: {login}");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Registration Date: {registrationDate}");
    }
}