namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
string input = Console.ReadLine();
            string[] nums = input.Split(" ");
            long num1 =long.Parse(nums[0]);
            long num2 =long.Parse(nums[1]);
            Console.WriteLine($"{num1} + {num2} = {num1+num2}");
            Console.WriteLine($"{num1} * {num2} = {num1*num2}");
            Console.WriteLine($"{num1} - {num2} = {num1-num2}");
        }
    }
}
