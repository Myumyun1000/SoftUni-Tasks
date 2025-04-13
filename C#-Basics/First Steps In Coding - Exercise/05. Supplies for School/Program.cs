int himikali = int.Parse(Console.ReadLine());
int markeri = int.Parse(Console.ReadLine());
int preparat = int.Parse(Console.ReadLine());
int namalenie = int.Parse(Console.ReadLine());

double pakethimikali = himikali * 5.80;
double paketmarkeri = markeri * 7.20;
double preparat2 = preparat * 1.20;

double nujnipari = pakethimikali + paketmarkeri + preparat2;
double nujnipariSNamalenie = nujnipari - (nujnipari * (namalenie / 100.0));

Console.WriteLine(nujnipariSNamalenie);