namespace _4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int backInMinutes = 30;
            int totalTime = (hours * 60) + minutes + backInMinutes;

            int newHours = totalTime / 60;
            int newMinutes = totalTime - newHours * 60;

            if (newHours > 23)
            {
                newHours -= 24;
            }
            Console.WriteLine($"{newHours:d2}:{newMinutes:D2}");
        }
    }
}