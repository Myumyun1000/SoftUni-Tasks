string animalName = Console.ReadLine();

if (animalName == "dog")
{
    Console.WriteLine("mammal");
}
else if (animalName == "snake" || animalName == "tortoise" || animalName == "crocodile")
{
    Console.WriteLine("reptile");
}
else
{
    Console.WriteLine("unknown");
}
