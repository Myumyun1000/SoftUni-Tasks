double total = 0;

string input = Console.ReadLine();

while (input != "NoMoreMoney")
{
    double amount = double.Parse(input);

    if (amount < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    Console.WriteLine($"Increase: {amount:F2}");
    total += amount;

    input = Console.ReadLine();
}

Console.WriteLine($"Total: {total:F2}");
