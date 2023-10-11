using System.Security.AccessControl;

namespace _7
{
    public class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            string output = string.Empty;
            switch (day.ToLower()) 
            {
                case "weekday":
                    price = GetPriseOfTicket(age,12,18,12);
                    break;
                case "weekend":
                    price = GetPriseOfTicket(age, 15, 20, 15);
                    break;
                case "woliday":
                    price = GetPriseOfTicket(age, 5, 12, 10);
                    break;
                default:
                    Console.WriteLine("Error! Type of day is not valid.");
                    break;                   
            }
            output = price == 0 ? "Error!" : $"{price}$";
            Console.WriteLine(output);
        }

        private static int GetPriseOfTicket(int age, int kid, int adult, int old)
        {         
            if (0 <= age & age <= 18)
            {
                return kid;
            }
            else if (18 < age & age <= 64)
            {
                return adult;
            }   
            else if (64 < age & age <= 122)
            {
                return old;
            }
            else
            {
                return 0;
            }
        }
    }
}