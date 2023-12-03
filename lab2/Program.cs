using System;



class Program
{
    static void Main()
    {
        // Create an instance of the Address class
        Address myAddress = new Address();

        // Set values for the address fields
        myAddress.Index = "12345";
        myAddress.Country = "Ukraine";
        myAddress.City = "Kyiv";
        myAddress.Street = "Main Street";
        myAddress.House = "42";
        myAddress.Apartment = "7";

        // Display the address information
        Console.WriteLine("Address Information:");
        Console.WriteLine($"Index: {myAddress.Index}");
        Console.WriteLine($"Country: {myAddress.Country}");
        Console.WriteLine($"City: {myAddress.City}");
        Console.WriteLine($"Street: {myAddress.Street}");
        Console.WriteLine($"House: {myAddress.House}");
        Console.WriteLine($"Apartment: {myAddress.Apartment}");

        // Keep the console window open
        Console.ReadLine();
    }
}
