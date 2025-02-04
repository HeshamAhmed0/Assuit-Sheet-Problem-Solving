namespace Z._Hard_Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
string Input = Console.ReadLine();
            string[] Numbers = Input.Split(" ");
            long Num1 = long.Parse(Numbers[0]);
            long Num2= long.Parse(Numbers[1]);
            long Num3= long.Parse(Numbers[2]);
            long Num4= long.Parse(Numbers[3]);
            double R1=Math.Pow(Num1, Num2);
            double R2=Math.Pow(Num3, Num4);
            long Result1 = (long)R1;
            long Result2 = (long)R2;
            if (Result1==Result2|| Result1<Result2)
            {
                Console.WriteLine("NO");
            }else if (Result1>Result2)
            {
                Console.WriteLine("YES");
            }
            
        }
    }
}
