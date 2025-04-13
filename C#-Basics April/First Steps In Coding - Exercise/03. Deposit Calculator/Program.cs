double depoziranasuma = double.Parse(Console.ReadLine());
int sroknadepozita = int.Parse(Console.ReadLine());
double godishenlihvenprocent = double.Parse(Console.ReadLine());
double suma = depoziranasuma + sroknadepozita * ((depoziranasuma * godishenlihvenprocent / 100)) /12;
Console.WriteLine(suma);