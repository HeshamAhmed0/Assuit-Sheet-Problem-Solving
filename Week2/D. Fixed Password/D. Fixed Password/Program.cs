namespace D._Fixed_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int CorrectPassword = 1999;
            int INput = int.Parse(Console.ReadLine());
            bool IsTRue=true;
            while (true) 
            {
                if (INput != 1999)
                {
                    Console.WriteLine("Wrong");
                    INput = int.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Correct");
                    IsTRue = false;
                    break;
                }

            }

        }
    }
}
