namespace Basic_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Read
            Console.WriteLine("Enter int , Long , Char , Float , Double");
            string input = Console.ReadLine();
            string[] Collection = input.Split(" ");
            int num1 = int.Parse(Collection[0]);
            long num2 = long.Parse(Collection[1]);
            char ch = char.Parse(Collection[2]);
            float num3 = float.Parse(Collection[3]);
            double num4 = double.Parse(Collection[4]); 
            #endregion

            Console.Clear();

            #region Write
            Console.WriteLine($"int    num = {num1}");
            Console.WriteLine($"Long   num = {num2}");
            Console.WriteLine($"Char   ch  = {ch}");
            Console.WriteLine($"Float  num = {num3}");
            Console.WriteLine($"double num = {num4}"); 
            #endregion
        }
    }
}
