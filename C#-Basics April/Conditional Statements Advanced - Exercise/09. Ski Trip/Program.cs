
        int daysToStay = int.Parse(Console.ReadLine());
        string room = Console.ReadLine();
        string assessment = Console.ReadLine();

        double price = 0.0;
        if (room == "room for one person")
        {
            price = 18.00 * (daysToStay - 1);
        }
        else if (room == "apartment")
        {
            price = 25.00 * (daysToStay - 1);
            if (daysToStay < 10)
            {
                price = price * 0.70;
            }
            else if (daysToStay >= 10 && daysToStay <= 15)
            {
                price = price * 0.65;
            }
            else if (daysToStay > 15)
            {
                price = price * 0.50;
            }
        }
        else if (room == "president apartment")
        {
            price = 35.00 * (daysToStay - 1);
            if (daysToStay < 10)
            {
                price = price * 0.90;
            }
            else if (daysToStay >= 10 && daysToStay <= 15)
            {
                price = price * 0.85;
            }
            else if (daysToStay > 15)
            {
                price = price * 0.80;
            }
        }
        if (assessment == "positive")
        {
            price = price * 1.25;
        }
        else if (assessment == "negative")
        {
            price = price * 0.90;
        }
        Console.WriteLine($"{price:F2}");
