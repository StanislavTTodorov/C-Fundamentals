namespace _9.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oddNumbers = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int count = 1;
            while (oddNumbers>0)
            {    
                if (count%2 != 0)
                {
                    Console.WriteLine(count);
                    totalSum += count;
                    oddNumbers -= 1;
                }                  
                    count += 1;               
            }
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}