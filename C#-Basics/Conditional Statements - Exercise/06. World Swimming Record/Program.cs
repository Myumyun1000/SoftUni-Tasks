double recordTime = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timePerMeter = double.Parse(Console.ReadLine());

double swimmingTime = distance * timePerMeter;
double delayTime = Math.Floor(distance / 15) * 12.5;
double totalTime = swimmingTime + delayTime;

if (totalTime < recordTime)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {totalTime - recordTime:F2} seconds slower.");
}
