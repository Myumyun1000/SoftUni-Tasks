
        int naylon = int.Parse(Console.ReadLine());
        int boya = int.Parse(Console.ReadLine());
        int razreditel = int.Parse(Console.ReadLine());
        int chasove = int.Parse(Console.ReadLine());

        double cenaNaylon = (naylon + 2) * 1.50;
        double cenaBoya = (boya + boya * 0.10) * 14.50;
        double cenaRazreditel = razreditel * 5.00;
        double cenaTorbi = 0.40;

        double sumaMateriali = cenaNaylon + cenaBoya + cenaRazreditel + cenaTorbi;

        double sumaMajstori = (sumaMateriali * 0.30) * chasove;

        double krainaSuma = sumaMateriali + sumaMajstori;

        Console.WriteLine(krainaSuma);

