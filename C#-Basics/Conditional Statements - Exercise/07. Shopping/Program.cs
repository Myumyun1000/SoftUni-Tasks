double budget = double.Parse(Console.ReadLine());
int numGraphicsCards = int.Parse(Console.ReadLine());
int numProcessors = int.Parse(Console.ReadLine());
int numRam = int.Parse(Console.ReadLine());

double priceGraphicsCard = 250;
double priceProcessorPerCard = 0.35;
double priceRamPerCard = 0.10;

double totalPriceGraphicsCards = numGraphicsCards * priceGraphicsCard;
double totalPriceProcessors = numProcessors * totalPriceGraphicsCards * priceProcessorPerCard;
double totalPriceRam = numRam * totalPriceGraphicsCards * priceRamPerCard;

double totalCost = totalPriceGraphicsCards + totalPriceProcessors + totalPriceRam;

if (numGraphicsCards > numProcessors)
{
    totalCost *= 0.85;
}

if (totalCost <= budget)
{
    Console.WriteLine($"You have {budget - totalCost:F2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {totalCost - budget:F2} leva more!");
}