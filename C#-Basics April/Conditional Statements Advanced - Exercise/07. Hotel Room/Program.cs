using System;
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

     
        double studioPrice = 0.0;
        double apartmentPrice = 0.0;


if (month == "May" || month == "October")
{
    studioPrice = 50.00;
    apartmentPrice = 65.00;
    if (nights > 14) studioPrice *= 0.70;
    else if (nights > 7) studioPrice *= 0.95;
}
else if (month == "June" || month == "September")
{
    studioPrice = 75.20;
    apartmentPrice = 68.70;
    if (nights > 14) studioPrice *= 0.80;
}
else if (month == "July" || month == "August")
{
    studioPrice = 76.00;
    apartmentPrice = 77.00;
}

        
        if (nights > 14)
        {
            apartmentPrice *= 0.90; 
        }

        
        double totalStudioPrice = studioPrice * nights;
        double totalApartmentPrice = apartmentPrice * nights;

        Console.WriteLine($"Apartment: {totalApartmentPrice:F2} lv.");
        Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
    

