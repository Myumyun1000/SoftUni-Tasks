        string favoriteBook = Console.ReadLine();
        string input;
        int booksChecked = 0;

        while ((input = Console.ReadLine()) != "No More Books")
        {
            if (input == favoriteBook)
            {
                Console.WriteLine($"You checked {booksChecked} books and found it.");
                return;
            }

            booksChecked++;
        }

        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {booksChecked} books.");

