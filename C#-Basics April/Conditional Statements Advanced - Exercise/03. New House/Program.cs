using System;
       
        string flowerType = Console.ReadLine();
        int flowerCount = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());
        double pricePerFlower = 0;

        switch (flowerType)
        {
            case "Roses":
                pricePerFlower = 5;
                break;
            case "Dahlias":
                pricePerFlower = 3.80;
                break;
            case "Tulips":
                pricePerFlower = 2.80;
                break;
            case "Narcissus":
                pricePerFlower = 3;
                break;
            case "Gladiolus":
                pricePerFlower = 2.50;
                break;
        }
        double totalPrice = flowerCount * pricePerFlower;
        if (flowerType == "Roses" && flowerCount > 80)
        {
            totalPrice *= 0.90;
        }
        else if (flowerType == "Dahlias" && flowerCount > 90)
        {
            totalPrice *= 0.85;
        }
        else if (flowerType == "Tulips" && flowerCount > 80)
        {
            totalPrice *= 0.85;
        }
        else if (flowerType == "Narcissus" && flowerCount < 120)
        {
            totalPrice *= 1.15;
        }
        else if (flowerType == "Gladiolus" && flowerCount < 80)
        {
            totalPrice *= 1.20;
        }
        if (budget >= totalPrice)
        {
            Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {budget - totalPrice:f2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
        }
 
