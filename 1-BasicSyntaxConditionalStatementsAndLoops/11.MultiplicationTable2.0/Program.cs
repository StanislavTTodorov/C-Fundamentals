namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int inputNumber = int.Parse(Console.ReadLine());
          int startNumber = int.Parse(Console.ReadLine());
            int count = 10 - startNumber;
            if (startNumber > 0 && startNumber <= 100)
            {
                do
                {
                    count -= 1;
                    int sum = inputNumber * startNumber;
                    Console.WriteLine($"{inputNumber} X {startNumber} = {sum}");
                    startNumber += 1;

                } while (count >= 0);
            }
        }
    }
}