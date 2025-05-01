        string city = Console.ReadLine();
        double sales = double.Parse(Console.ReadLine());

        double commission = 0.0;

        if (sales < 0)
        {
            Console.WriteLine("error");
            return;
        }

        if (city == "Sofia")
        {
            if (sales <= 500)
                commission = 0.05;
            else if (sales <= 1000)
                commission = 0.07;
            else if (sales <= 10000)
                commission = 0.08;
            else
                commission = 0.12;
        }
        else if (city == "Varna")
        {
            if (sales <= 500)
                commission = 0.045;
            else if (sales <= 1000)
                commission = 0.075;
            else if (sales <= 10000)
                commission = 0.10;
            else
                commission = 0.13;
        }
        else if (city == "Plovdiv")
        {
            if (sales <= 500)
                commission = 0.055;
            else if (sales <= 1000)
                commission = 0.08;
            else if (sales <= 10000)
                commission = 0.12;
            else
                commission = 0.145;
        }
        else
        {
            Console.WriteLine("error");
            return;
        }

        double totalCommission = sales * commission;
        Console.WriteLine($"{totalCommission:F2}");
