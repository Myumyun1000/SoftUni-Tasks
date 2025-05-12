       int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());

        int totalPieces = width * length;
        int takenPieces = 0;

        while (takenPieces < totalPieces)
        {
            string input = Console.ReadLine();

            if (input == "STOP")
            {
                Console.WriteLine($"{totalPieces - takenPieces} pieces are left.");
                return;
            }

            int pieces = int.Parse(input);
            takenPieces += pieces;
        }

        Console.WriteLine($"No more cake left! You need {takenPieces - totalPieces} pieces more.");
