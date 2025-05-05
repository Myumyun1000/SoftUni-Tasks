int age = int.Parse(Console.ReadLine());
double priceWashingMachine = double.Parse(Console.ReadLine());
int pricePerToy = int.Parse(Console.ReadLine());

int toysCount = 0;
int moneyFromBirthdays = 0;
int currentMoney = 10;
int moneyTakenByBrother = 0;

for (int year = 1; year <= age; year++)
{
    if (year % 2 == 0)
    {
        moneyFromBirthdays += currentMoney;
        currentMoney += 10;
        moneyTakenByBrother++;
    }
    else
    {
        toysCount++;
    }
}

int moneyFromToys = toysCount * pricePerToy;
double totalSavedMoney = moneyFromBirthdays - moneyTakenByBrother + moneyFromToys;

if (totalSavedMoney >= priceWashingMachine)
{
    Console.WriteLine($"Yes! {(totalSavedMoney - priceWashingMachine):F2}");
}
else
{
    Console.WriteLine($"No! {(priceWashingMachine - totalSavedMoney):F2}");
}
