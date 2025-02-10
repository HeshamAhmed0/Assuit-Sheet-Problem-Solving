namespace C._Even__Odd__Positive_and_Negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number_of_Even = 0;
            int Number_of_Odd = 0;
            int Number_of_Positive = 0;
            int Number_of_Negative= 0;
            int NumOfNumbers=int.Parse(Console.ReadLine());
            string input=Console.ReadLine();
            string[] inputs =input.Split(' ');
            int[] Numbers =new int[NumOfNumbers];
            for (int i=0;i<input.Length;i++)
            {
                Numbers[i] = int.Parse(inputs[i]);
            }

            foreach (int i in Numbers)
            {
                if (i < 0)
                {
                    Number_of_Negative++;
                    if (i%2!=0)
                    {
                        Number_of_Odd++;
                    }
                    else
                    {
                        Number_of_Even++;
                    }
                }
                else if (i == 0)
                {
                    Number_of_Even++;
                }
                else if (i>0)
                {
                    Number_of_Positive++;
                    if (i%2==0) { Number_of_Even++; }
                    else { Number_of_Odd++; }

                }
            }
            Console.WriteLine($"Even: {Number_of_Even}");
            Console.WriteLine($"Ood: {Number_of_Odd}");
            Console.WriteLine($"Positive: {Number_of_Positive}");
            Console.WriteLine($"Negative: {Number_of_Negative}");
        }
    }
}
