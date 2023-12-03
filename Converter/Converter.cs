class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    // Custom constructor to initialize currency exchange rates
    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    // Method to convert from UAH to USD
    public double UahToUsd(double amount)
    {
        return amount / usdRate;
    }

    // Method to convert from UAH to EUR
    public double UahToEur(double amount)
    {
        return amount / eurRate;
    }

    // Method to convert from UAH to PLN
    public double UahToPln(double amount)
    {
        return amount / plnRate;
    }

    // Method to convert from USD to UAH
    public double UsdToUah(double amount)
    {
        return amount * usdRate;
    }

    // Method to convert from EUR to UAH
    public double EurToUah(double amount)
    {
        return amount * eurRate;
    }

    // Method to convert from PLN to UAH
    public double PlnToUah(double amount)
    {
        return amount * plnRate;
    }
}
