string actorName = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int juryCount = int.Parse(Console.ReadLine());

for (int i = 0; i < juryCount; i++)
{
    string juryName = Console.ReadLine();
    double juryPoints = double.Parse(Console.ReadLine());

    points += (juryName.Length * juryPoints) / 2;

    if (points > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:F1}!");
        return;
    }
}

double neededPoints = 1250.5 - points;
Console.WriteLine($"Sorry, {actorName} you need {neededPoints:F1} more!");
