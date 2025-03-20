namespace F._Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Input =int.Parse(Console.ReadLine());
            for(int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{Input} * {i} = {Input*i}");
            }
        }
    }
}
