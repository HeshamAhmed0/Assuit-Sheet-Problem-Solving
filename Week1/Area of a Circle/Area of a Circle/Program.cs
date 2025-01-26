
namespace Area_of_a_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter R : ");
            int R =int.Parse(Console.ReadLine());
           const  double  Pi = 3.141592653;
            double Area = Pi * R * R;
            Console.WriteLine(Math.Round(Area, 9)); 
        }
    }
}
