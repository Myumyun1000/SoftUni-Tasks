﻿int groupCount = int.Parse(Console.ReadLine());

int musala = 0;
int monblan = 0;
int kilimanjaro = 0;
int k2 = 0;
int everest = 0;

int totalPeople = 0;

for (int i = 0; i < groupCount; i++)
{
    int people = int.Parse(Console.ReadLine());
    totalPeople += people;

    if (people <= 5)
    {
        musala += people;
    }
    else if (people <= 12)
    {
        monblan += people;
    }
    else if (people <= 25)
    {
        kilimanjaro += people;
    }
    else if (people <= 40)
    {
        k2 += people;
    }
    else
    {
        everest += people;
    }
}

Console.WriteLine($"{(musala * 100.0 / totalPeople):F2}%");
Console.WriteLine($"{(monblan * 100.0 / totalPeople):F2}%");
Console.WriteLine($"{(kilimanjaro * 100.0 / totalPeople):F2}%");
Console.WriteLine($"{(k2 * 100.0 / totalPeople):F2}%");
Console.WriteLine($"{(everest * 100.0 / totalPeople):F2}%");
