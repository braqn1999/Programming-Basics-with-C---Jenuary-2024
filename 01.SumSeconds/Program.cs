int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int totalTime = firstTime + secondTime + thirdTime;

int minutes = totalTime / 60;
int second = totalTime % 60;

if (second < 10)
{
    Console.WriteLine($"{minutes}:0{second}");
}
else
{
    Console.WriteLine($"{minutes}:{second}");
}
