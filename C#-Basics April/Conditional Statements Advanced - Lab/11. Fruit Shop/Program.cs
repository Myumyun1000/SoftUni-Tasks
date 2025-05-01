        string fruit = Console.ReadLine();
        string day = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        double price = 0.0;

        bool isWeekday = day == "Monday" || day == "Tuesday" || day == "Wednesday" ||
                         day == "Thursday" || day == "Friday";
        bool isWeekend = day == "Saturday" || day == "Sunday";

        if (isWeekday)
        {
            if (fruit == "banana") price = 2.50;
            else if (fruit == "apple") price = 1.20;
            else if (fruit == "orange") price = 0.85;
            else if (fruit == "grapefruit") price = 1.45;
            else if (fruit == "kiwi") price = 2.70;
            else if (fruit == "pineapple") price = 5.50;
            else if (fruit == "grapes") price = 3.85;
            else
            {
                Console.WriteLine("error");
                return;
            }
        }
        else if (isWeekend)
        {
            if (fruit == "banana") price = 2.70;
            else if (fruit == "apple") price = 1.25;
            else if (fruit == "orange") price = 0.90;
            else if (fruit == "grapefruit") price = 1.60;
            else if (fruit == "kiwi") price = 3.00;
            else if (fruit == "pineapple") price = 5.60;
            else if (fruit == "grapes") price = 4.20;
            else
            {
                Console.WriteLine("error");
                return;
            }
        }
        else
        {
            Console.WriteLine("error");
            return;
        }

        double totalPrice = quantity * price;
        Console.WriteLine($"{totalPrice:F2}");
