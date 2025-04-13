int chikenmenu = int.Parse(Console.ReadLine());
int fishmenu = int.Parse(Console.ReadLine());
int veganmenu = int.Parse(Console.ReadLine());
double allsum = chikenmenu * 10.35 + fishmenu * 12.40 + veganmenu * 8.15;
double cakeprice = 0.2 * allsum;
double finalsum = allsum + cakeprice + 2.50;
Console.WriteLine(finalsum);
