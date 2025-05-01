int degrees = int.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();
if (degrees >=10 && degrees <=18)
{
    if (timeOfDay == "Morning")
        {

        string outfit = "Sweatshirt";
        string shoes = "Sneakers";
        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    if (timeOfDay == "Afternoon")
    {
        string outfit = "Shirt";
        string shoes = "Moccasins";
        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
    if (timeOfDay == "Evening")
    {
        string outfit = "Shirt";
        string shoes = "Moccasins";
        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");

    }
}
if (degrees > 18 && degrees <= 24)
{
    switch (timeOfDay)
    {
        case "Morning":
        case "Evening":
            string outfit = "Shirt";
            string shoes = "Moccasins";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;

        case "Afternoon":
            outfit = "T-Shirt";
            shoes = "Sandals";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;
    }
}
if (degrees >= 25 && degrees <= 42)
{
    switch (timeOfDay)
    {
        case "Morning":
            string outfit = "T-Shirt";
            string shoes = "Sandals";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;

        case "Afternoon":
            outfit = "Swim Suit";
            shoes = "Barefoot";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;
            case "Evening":
                outfit = "Shirt";
            shoes = "Moccasins";
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            break;


    }
}


