namespace E._Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CountOfNumbers=int.Parse(Console.ReadLine());
            string[] Numbers =new string[CountOfNumbers];
            String Input=Console.ReadLine();
            Numbers = Input.Split(' ');
            int[] IntNumbers =Array.ConvertAll(Numbers,int.Parse);

           
           
            int Result = IntNumbers[0];
            for (int i = 0; i < CountOfNumbers; i++)
            {
                if (IntNumbers[i] > Result)
                {
                    Result = IntNumbers[i];
                }
            }
            Console.WriteLine(Result);

        }
    }
}
