int n = int.Parse(Console.ReadLine());

int countP1 = 0;
int countP2 = 0;
int countP3 = 0;
int countP4 = 0;
int countP5 = 0;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());

    if (num < 200)
    {
        countP1++;
    }
    else if (num <= 399)
    {
        countP2++;
    }
    else if (num <= 599)
    {
        countP3++;
    }
    else if (num <= 799)
    {
        countP4++;
    }
    else
    {
        countP5++;
    }
}
Console.WriteLine($"{(countP1 * 100.0 / n):F2}%");
Console.WriteLine($"{(countP2 * 100.0 / n):F2}%");
Console.WriteLine($"{(countP3 * 100.0 / n):F2}%");
Console.WriteLine($"{(countP4 * 100.0 / n):F2}%");
Console.WriteLine($"{(countP5 * 100.0 / n):F2}%");
