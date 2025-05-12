        double tripMoneyNeeded = double.Parse(Console.ReadLine());
        double currentMoney = double.Parse(Console.ReadLine());

        int daysCounter = 0;
        int spendDaysCounter = 0;

        while (currentMoney < tripMoneyNeeded)
        {
            string action = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            daysCounter++;

            if (action == "spend")
            {
                spendDaysCounter++;
                currentMoney -= amount;

                if (currentMoney < 0)
                {
                    currentMoney = 0;
                }

                if (spendDaysCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(daysCounter);
                    return;
                }
            }
            else if (action == "save")
            {
                currentMoney += amount;
                spendDaysCounter = 0;
            }
        }

        Console.WriteLine($"You saved the money for {daysCounter} days.");
