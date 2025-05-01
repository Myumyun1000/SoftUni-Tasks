using System.Data.Common;

string projection = Console.ReadLine();
int lines = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
double price = 0.0;
if (projection == "Premiere")
    price = 12.00;
else if (projection == "Normal")
    price = 7.50;
else if (projection == "Discount")
    price = 5.00;

double totalRevenue = price * lines * columns;
Console.WriteLine($"{totalRevenue:F2}");
