int godishnataksa = int.Parse(Console.ReadLine());
double kecove = godishnataksa - (godishnataksa * 0.40);
double ekip = kecove - (kecove * 0.20);
double topka = ekip / 4;
double aksesoari = topka / 5;
double sum = godishnataksa + kecove + ekip + topka + aksesoari;
Console.WriteLine(sum);
