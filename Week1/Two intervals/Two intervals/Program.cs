using System;
namespace Two_intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers =input.Split(' ');
            long num1 = long.Parse(numbers[0]);
            long num2 = long.Parse(numbers[1]);
            long num3 = long.Parse(numbers[2]);
            long num4 = long.Parse(numbers[3]);
            long[] nums =new long[num4];
           
            
            if (num3>num1&&num3>num2)
            {
                Console.WriteLine("-1");
            }else if (num3 > num1 && num3 < num2&&num4>num3)
            {
                Console.WriteLine($"{num3} {num2}");
            }else if (num3 > num1 && num3 < num2 && num4 < num3)
            {
                Console.WriteLine($"{num3} {num4}");

            }

        }
    }
}
