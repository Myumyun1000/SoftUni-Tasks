﻿        string name = Console.ReadLine();
        int grades = 1;
        double sum = 0;
        int excluded = 0;

        while (grades <= 12)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade < 4.00)
            {
                excluded++;

                if (excluded > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {grades} grade");
                    return;
                }

                continue;
            }

            sum += grade;
            grades++;
        }

        double average = sum / 12;
        Console.WriteLine($"{name} graduated. Average grade: {average:F2}");

