double tripPrice = double.Parse(Console.ReadLine());
int puzzles = int.Parse(Console.ReadLine());
int talkingDolls = int.Parse(Console.ReadLine());
int teddies = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

double totalPrice = puzzles * 2.60 + talkingDolls * 3.00 + teddies * 4.10 + minions * 8.20 + trucks * 2.00;

if (puzzles + talkingDolls + teddies + minions + trucks >= 50)
{
    totalPrice *= 0.75;
}

totalPrice *= 0.90;

if (totalPrice >= tripPrice)
{
    Console.WriteLine($"Yes! {totalPrice - tripPrice:F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {tripPrice - totalPrice:F2} lv needed.");
}

