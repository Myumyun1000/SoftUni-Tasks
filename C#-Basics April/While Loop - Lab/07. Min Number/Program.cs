int min = int.MaxValue;
string input = Console.ReadLine();

while (input != "Stop")
{
    int number = int.Parse(input);
    if (number < min)
    {
        min = number;
    }

    input = Console.ReadLine();
}

Console.WriteLine(min);
