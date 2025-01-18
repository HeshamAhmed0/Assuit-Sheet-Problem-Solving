namespace Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter four numbers : ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(" ");
            long num1 = Convert.ToInt64(numbers[0]);
            long num2 = Convert.ToInt64(numbers[1]);
            long num3 = Convert.ToInt64(numbers[2]);
            long num4 = Convert.ToInt64(numbers[3]);
        }
    }
}
