﻿        int maxPoorGrades = int.Parse(Console.ReadLine());
        int poorGradesCount = 0;
        int problemsCount = 0;
        double gradesSum = 0;
        string lastProblem = "";

        while (true)
        {
            string problemName = Console.ReadLine();

            if (problemName == "Enough")
            {
                Console.WriteLine($"Average score: {gradesSum / problemsCount:F2}");
                Console.WriteLine($"Number of problems: {problemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
                break;
            }

            int grade = int.Parse(Console.ReadLine());
            gradesSum += grade;
            problemsCount++;
            lastProblem = problemName;

            if (grade <= 4)
            {
                poorGradesCount++;

                if (poorGradesCount == maxPoorGrades)
                {
                    Console.WriteLine($"You need a break, {poorGradesCount} poor grades.");
                    break;
                }
            }
        }
