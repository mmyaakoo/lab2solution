using System;


class Program
{
    static void Main()
    {
        // Create an instance of the Employee class
        Employee employee = new Employee("Doe", "John");

        // Display employee information
        employee.DisplayEmployeeInfo("Developer", 5);

        // Keep the console window open
        Console.ReadLine();
    }
}
