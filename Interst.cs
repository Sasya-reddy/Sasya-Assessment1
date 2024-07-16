class interset
{
    static void Main()
    {
        double principal = 1000.00;
        double rate = 0.05;
        double targetAmount = 100000.00;
        double amount = principal;
        int years = 0;

        while (amount <= targetAmount)
        {
            amount += amount * rate;
            years++;
        }

        Console.WriteLine($"It will take {years} years to reach or exceed Rs {targetAmount}.");
    }
}