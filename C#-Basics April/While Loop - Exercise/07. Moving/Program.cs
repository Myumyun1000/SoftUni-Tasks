        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int totalVolume = width * length * height;
        int usedVolume = 0;

        while (usedVolume < totalVolume)
        {
            string input = Console.ReadLine();

            if (input == "Done")
            {
                Console.WriteLine($"{totalVolume - usedVolume} Cubic meters left.");
                return;
            }

            int boxes = int.Parse(input);
            usedVolume += boxes;
        }

        Console.WriteLine($"No more free space! You need {usedVolume - totalVolume} Cubic meters more.");
