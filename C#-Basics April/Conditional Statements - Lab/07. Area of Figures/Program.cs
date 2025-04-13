string figure = Console.ReadLine();
if (figure == "square")
{
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine($"{a * a:F3}");
}
else if (figure == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine($"{a * b:F3}");
}
else if (figure == "circle")
{
    double r = double.Parse(Console.ReadLine());
    double s = r * r * Math.PI;
    Console.WriteLine($" {s:F3}");

}
else if (figure == "triangle")
{
    double a = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    double s = a * h / 2;
    Console.WriteLine($"{s:F3}");
}
