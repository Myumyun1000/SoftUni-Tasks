       double change = double.Parse(Console.ReadLine());
        int coinsCount = 0;
        int changeInCents = (int)Math.Round(change * 100);

        int[] coins = { 200, 100, 50, 20, 10, 5, 2, 1 };

        foreach (int coin in coins)
        {
            while (changeInCents >= coin)
            {
                changeInCents -= coin;
                coinsCount++;
            }
        }

        Console.WriteLine(coinsCount);