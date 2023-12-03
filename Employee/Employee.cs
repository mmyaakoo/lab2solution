class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void DisplayEmployeeInfo(string position, int experienceYears)
    {
        // Calculate salary based on position and experience
        double baseSalary = CalculateBaseSalary(position);
        double experienceBonus = CalculateExperienceBonus(experienceYears);
        double totalSalary = baseSalary + experienceBonus;

        // Calculate tax (assuming a fixed rate for simplicity)
        double taxRate = 0.15; // 15% tax rate
        double tax = totalSalary * taxRate;

        // Display employee information
        Console.WriteLine("Employee Information:");
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Base Salary: {baseSalary:C}");
        Console.WriteLine($"Experience Bonus: {experienceBonus:C}");
        Console.WriteLine($"Total Salary: {totalSalary:C}");
        Console.WriteLine($"Tax: {tax:C}");
    }

    private double CalculateBaseSalary(string position)
    {
        // Add logic to determine base salary based on position
        // For simplicity, using fixed values here
        switch (position.ToLower())
        {
            case "manager":
                return 50000.0;
            case "developer":
                return 60000.0;
            case "designer":
                return 55000.0;
            default:
                return 50000.0;
        }
    }

    private double CalculateExperienceBonus(int experienceYears)
    {
        // Add logic to determine experience bonus
        // For simplicity, using a fixed bonus per year of experience
        double experienceBonusRate = 1000.0;
        return experienceYears * experienceBonusRate;
    }
}
