int max = int.MinValue;
string input = Console.ReadLine();

while (input != "Stop")
{
    int number = int.Parse(input);
    if (number > max)
    {
        max = number;
    }

    input = Console.ReadLine();
}

Console.WriteLine(max);
