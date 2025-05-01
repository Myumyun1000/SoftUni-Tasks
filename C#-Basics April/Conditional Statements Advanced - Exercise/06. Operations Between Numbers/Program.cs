
        int N1 = int.Parse(Console.ReadLine());
        int N2 = int.Parse(Console.ReadLine());
        char operatorSymbol = char.Parse(Console.ReadLine());
        if (operatorSymbol == '+')
        {
            int result = N1 + N2;
            Console.WriteLine($"{N1} + {N2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
        }
        else if (operatorSymbol == '-')
        {
            int result = N1 - N2;
            Console.WriteLine($"{N1} - {N2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
        }
        else if (operatorSymbol == '*')
        {
            int result = N1 * N2;
            Console.WriteLine($"{N1} * {N2} = {result} - {(result % 2 == 0 ? "even" : "odd")}");
        }
        else if (operatorSymbol == '/')
        {
            if (N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else
            {
                double result = (double)N1 / N2;
                Console.WriteLine($"{N1} / {N2} = {result:F2}");
            }
        }
        else if (operatorSymbol == '%')
        {
            if (N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else
            {
                int remainder = N1 % N2;
                Console.WriteLine($"{N1} % {N2} = {remainder}");
            }
        }
