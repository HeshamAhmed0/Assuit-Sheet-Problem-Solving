namespace B._Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Input =int.Parse(Console.ReadLine());
            if (Input<=1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                for (int Start = 2; Start <= Input; Start += 2)
                {
                    
                        Console.WriteLine(Start);
                   
                }
            }
        }
    }
}
