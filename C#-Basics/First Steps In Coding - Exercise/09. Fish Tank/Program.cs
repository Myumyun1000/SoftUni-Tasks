int duljinasm = int.Parse(Console.ReadLine());
int shirochinasm = int.Parse(Console.ReadLine());
int visochina = int.Parse(Console.ReadLine());
double procent = double.Parse(Console.ReadLine());
int obemnnaakvarium = duljinasm * shirochinasm * visochina;
double obemvlitri = obemnnaakvarium * 0.001;
double zaetoprostranstvo = procent / 100;
double nujnilitri = obemvlitri * (1 - zaetoprostranstvo);
Console.WriteLine(nujnilitri);
