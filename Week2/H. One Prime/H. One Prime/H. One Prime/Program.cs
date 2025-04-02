namespace H._One_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Input =int.Parse(Console.ReadLine());
            string Out = "YES";
           for (int i =2; i<Input;i++)
            {
                var Value = Input / i;
                Console.WriteLine(Value);
                if (Value is int)
                {
                    Out = "NO";
                    break;
                }
                else
                {
                    Out = "YES";
                    break;
                }
            }
            Console.WriteLine(Out);
        }
    }
}
