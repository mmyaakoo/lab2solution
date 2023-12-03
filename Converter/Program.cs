using System;



class Program
{
    static void Main()
    {
        // Create an instance of the Converter class with exchange rates
        Converter converter = new Converter(28.0, 33.0, 7.5);

        // Convert from UAH to USD
        double uahAmount = 1000.0;
        double usdResult = converter.UahToUsd(uahAmount);
        Console.WriteLine($"{uahAmount} UAH is equal to {usdResult} USD");

        // Convert from USD to UAH
        double usdAmount = 50.0;
        double uahResult = converter.UsdToUah(usdAmount);
        Console.WriteLine($"{usdAmount} USD is equal to {uahResult} UAH");

        // You can perform similar conversions for EUR and PLN

        // Keep the console window open
        Console.ReadLine();
    }
}
