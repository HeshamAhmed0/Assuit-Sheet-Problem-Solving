namespace Y._The_last_2_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Input =Console.ReadLine();
            string[] Numbers = Input.Split(' ');
            long Num1= long.Parse(Numbers[0]);
            long Num2 = long.Parse(Numbers[1]);
            long Num3 = long.Parse(Numbers[2]);
            long Num4 = long.Parse(Numbers[3]);
            long partNum1 = Num1 % 100;
            long partNum2 = Num2 % 100;
            long partNum3 = Num3 % 100;
            long partNum4 = Num4 % 100;
            long part1 = (partNum1 * partNum2) % 100;
            long part2 = (partNum3 * partNum4) % 100;
            long Result = (part1 * part2) % 100;
            Console.WriteLine(Result.ToString("D2"));

        }
    }
}
