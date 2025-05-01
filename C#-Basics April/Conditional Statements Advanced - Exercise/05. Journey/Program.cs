         double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destination = "";
        string typeOfVacation = "";
        double expense = 0;

      
        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season == "summer")
            {
                typeOfVacation = "Camp";
                expense = budget * 0.30;
            }
            else if (season == "winter")
            {
                typeOfVacation = "Hotel";
                expense = budget * 0.70;
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                typeOfVacation = "Camp";
                expense = budget * 0.40;
            }
            else if (season == "winter")
            {
                typeOfVacation = "Hotel";
                expense = budget * 0.80;
            }
        }
        else
        {
            destination = "Europe";
            typeOfVacation = "Hotel";
            expense = budget * 0.90;
        }

      
        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{typeOfVacation} - {expense:F2}");
    