int tournamentsCount = int.Parse(Console.ReadLine());
int startingPoints = int.Parse(Console.ReadLine());

int totalPoints = startingPoints;
int pointsFromTournaments = 0;
int wins = 0;

for (int i = 0; i < tournamentsCount; i++)
{
    string stage = Console.ReadLine();

    if (stage == "W")
    {
        pointsFromTournaments += 2000;
        wins++;
    }
    else if (stage == "F")
    {
        pointsFromTournaments += 1200;
    }
    else if (stage == "SF")
    {
        pointsFromTournaments += 720;
    }
}

totalPoints += pointsFromTournaments;
int averagePoints = pointsFromTournaments / tournamentsCount;
double winPercentage = wins * 100.0 / tournamentsCount;

Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {averagePoints}");
Console.WriteLine($"{winPercentage:F2}%");
