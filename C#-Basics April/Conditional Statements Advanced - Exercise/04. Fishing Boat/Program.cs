
        int budget = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        int numberOfFishermen = int.Parse(Console.ReadLine());

        double boatPrice = 0;
        if (season == "Spring")
        {
            boatPrice = 3000;
        }
        else if (season == "Summer" || season == "Autumn")
        {
            boatPrice = 4200;
        }
        else if (season == "Winter")
        {
            boatPrice = 2600;
        }

        double discount = 0;
        if (numberOfFishermen <= 6)
        {
            discount = 0.10;
        }
        else if (numberOfFishermen <= 11)
        {
            discount = 0.15; 
        }
        else
        {
            discount = 0.25;
        }
        double totalPrice = boatPrice * (1 - discount);
        if (numberOfFishermen % 2 == 0 && season != "Autumn")
        {
            totalPrice *= 0.95;
        }
        if (budget >= totalPrice)
        {
            Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
        }
