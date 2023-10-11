namespace _12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            while ((inputNumber = int.Parse(Console.ReadLine())) % 2!=0)
            {
                Console.WriteLine("Please write an even number.");
            }
            Console.WriteLine($"The number is: {Math.Abs(inputNumber)}");
        }
    }
}