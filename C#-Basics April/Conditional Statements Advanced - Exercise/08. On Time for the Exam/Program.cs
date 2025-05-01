        int examHour = int.Parse(Console.ReadLine());
        int examMinute = int.Parse(Console.ReadLine());
        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinute = int.Parse(Console.ReadLine());
        int examTimeInMinutes = examHour * 60 + examMinute;
        int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinute;
        int difference = arrivalTimeInMinutes - examTimeInMinutes;
        if (difference < -30)
        {
            Console.WriteLine("Early");
            difference = Math.Abs(difference);
            if (difference < 60)
            {
                Console.WriteLine($"{difference} minutes before the start");
            }
            else
            {
                int hours = difference / 60;
                int minutes = difference % 60;
                Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
            }
        }
        else if (difference <= 0)
        {
            Console.WriteLine("On time");
            difference = Math.Abs(difference);
            if (difference > 0)
            {
                Console.WriteLine($"{difference} minutes before the start");
            }
        }
        else
        {
            Console.WriteLine("Late");
            if (difference < 60)
            {
                Console.WriteLine($"{difference} minutes after the start");
            }
            else
            {
                int hours = difference / 60;
                int minutes = difference % 60;
                Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
            }
        }
  

