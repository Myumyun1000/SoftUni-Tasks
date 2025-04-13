double budget = double.Parse(Console.ReadLine());
int extras = int.Parse(Console.ReadLine());
double clothesPrice = double.Parse(Console.ReadLine());

double decorPrice = budget * 0.10;
double totalClothesPrice = extras * clothesPrice;

if (extras > 150)
{
    totalClothesPrice -= totalClothesPrice * 0.10;
}

double totalExpenses = decorPrice + totalClothesPrice;

if (totalExpenses > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {totalExpenses - budget:F2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budget - totalExpenses:F2} leva left.");
}
